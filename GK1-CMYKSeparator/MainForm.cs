using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.IO;

namespace GK1_P3_komoszynskil
{
    enum CurveColor
    {
        Cyan,
        Magenta,
        Yellow,
        Black
    }

    public partial class mainForm : Form
    {
        private CMYKConverter cmykConverter;
        private Bitmap realOriginalImage;
        private Bitmap originalImage;

        private byte[] originalImageBytes;
        private Bitmap cyanLayer;
        private Bitmap magentaLayer;
        private Bitmap yellowLayer;
        private Bitmap blackLayer;
        private CurveColor selectedCurveColor;

        private int pointRadius;
        private int bezierGridMargin;

        private int selectedPoint;

        private bool grabbing;
        private int k;
        public mainForm()
        {
            InitializeComponent();

            selectedCurveColor = CurveColor.Cyan;
            cmykConverter = new CMYKConverter();
            selectedPoint = -1;
            pointRadius = 6;

            bezierGridMargin = pointRadius * 2;

            k = 17;

            grabbing = false;

        }

        private void bezierGraphPictureBox_Paint(object sender, PaintEventArgs e)
        {
            CurveColor? layerType = null;

            if (!showAllCurvesCheckBox.Checked)
            {
                layerType = selectedCurveColor;
            }

            Painter.DrawGrayRamp(e.Graphics, cmykConverter, bezierGraphPictureBox.Width, bezierGraphPictureBox.Height, selectedCurveColor, pointRadius, selectedPoint, bezierGridMargin, layerType);
        }

        private void updateCmykLayers()
        {
            int width = originalImage.Width;
            int height = originalImage.Height;
            Byte[] cyanBytes = new Byte[width * height * 4];
            Byte[] magentaBytes = new Byte[width * height * 4];
            Byte[] yellowBytes = new Byte[width * height * 4];
            Byte[] blackBytes = new Byte[width * height * 4];

            progressBar1.Value = 0;

            bool inBlackAndWhite = noColorCheckbox.Checked;
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    int k = (j * width + i) * 4;

                    Color c = Color.FromArgb(originalImageBytes[k + 2], originalImageBytes[k + 1], originalImageBytes[k]);
                    CMYK cmyk = cmykConverter.FromRGB(c);

                    setLayerPixel(cmyk.RGBCyan(inBlackAndWhite), cyanBytes, k);
                    setLayerPixel(cmyk.RGBMagenta(inBlackAndWhite), magentaBytes, k);
                    setLayerPixel(cmyk.RGBYellow(inBlackAndWhite), yellowBytes, k);
                    setLayerPixel(cmyk.RGBKeyColor(), blackBytes, k);
                }

                progressBar1.Value = j * 100 / height;
            }

            copyLayerData(cyanLayer, cyanBytes);
            copyLayerData(magentaLayer, magentaBytes);
            copyLayerData(yellowLayer, yellowBytes);
            copyLayerData(blackLayer, blackBytes);

            progressBar1.Value = 100;
        }

        private void incrementColorDictionary(Color c, Dictionary<Color, int> D)
        {
            int currentCount;

            D.TryGetValue(c, out currentCount);

            D[c] = currentCount + 1;
        }

        private int getQuadrant(Color c)
        {
            if (c.R < 128)
            {
                if (c.G < 128)
                {
                    if (c.B < 128)
                    {
                        return 1;
                    }

                    return 2;
                }

                if (c.B < 128)
                {
                    return 3;
                }

                return 4;
            }
            if (c.G < 128)
            {
                if (c.B < 128)
                {
                    return 5;
                }
                return 6;
            }
            if (c.B < 128)
            {
                return 7;
            }
            return 8;
        }

        private float ColorDistance(Color c1, Color c2)
        {
            float dr = c2.R - c1.R;
            float dg = c2.R - c1.R;
            float db = c2.R - c1.R;

            return dr * dr + dg * dg + db * db;

        }

        private List<KeyValuePair<Color, int>> CreateSortedList(Dictionary<Color, int> D, int k) {
            int i = 0;
            List<KeyValuePair<Color, int>> tempList = new List<KeyValuePair<Color, int>>();
            foreach (var item in D.OrderByDescending(key => key.Value))
            {
                if (i >= k) break;
                tempList.Add(item);

                i++;
            }

            return tempList;
        }

        private Color getNearestColor(Color c, List<KeyValuePair<Color, int>> S)
        {
            float minColorDistance = float.PositiveInfinity;
            Color minColor = Color.Black;
            foreach(var item in S)
            {
                float tempDistance = ColorDistance(c, item.Key);

                if(tempDistance < minColorDistance)
                {
                    minColorDistance = tempDistance;
                    minColor = item.Key;
                }
            }

            return minColor;
        }

        private void reduceColors(Bitmap bitmap, int k)
        {

            int kp = k / 8;
            int offset = k - (kp * 8);

            Dictionary<Color, int> C1 = new Dictionary<Color, int>(); 
            Dictionary<Color, int> C2 = new Dictionary<Color, int>();
            Dictionary<Color, int> C3 = new Dictionary<Color, int>();
            Dictionary<Color, int> C4 = new Dictionary<Color, int>();

            Dictionary<Color, int> C5 = new Dictionary<Color, int>();
            Dictionary<Color, int> C6 = new Dictionary<Color, int>();
            Dictionary<Color, int> C7 = new Dictionary<Color, int>();
            Dictionary<Color, int> C8 = new Dictionary<Color, int>();

            List<KeyValuePair<Color, int>> S1, S2, S3, S4, S5, S6, S7, S8;

            originalImage = new Bitmap(realOriginalImage.Width, realOriginalImage.Height);
            for(int j = 0; j < realOriginalImage.Height; j++)
            {
                for(int i = 0; i < realOriginalImage.Width; i++)
                {
                    Color c = realOriginalImage.GetPixel(i, j);
                    Dictionary<Color, int> tempDict = getQuadrant(c) switch {
                        1 => C1,
                        2 => C2,
                        3 => C3,
                        4 => C4,
                        5 => C5,
                        6 => C6,
                        7 => C7,
                        8 => C8,
                        _ => C1
                    };

                    incrementColorDictionary(c, tempDict);
                }
            }

            S1 = CreateSortedList(C1, kp + offset);
            S2 = CreateSortedList(C2, kp);
            S3 = CreateSortedList(C3, kp);
            S4 = CreateSortedList(C4, kp);
            S5 = CreateSortedList(C5, kp);
            S6 = CreateSortedList(C6, kp);
            S7 = CreateSortedList(C7, kp);
            S8 = CreateSortedList(C8, kp);

            for (int j = 0; j < realOriginalImage.Height; j++)
            {
                for (int i = 0; i < realOriginalImage.Width; i++)
                {
                    Color c = realOriginalImage.GetPixel(i, j);

                    List<KeyValuePair<Color, int>> tempList = getQuadrant(c) switch
                    {
                        1 => S1,
                        2 => S2,
                        3 => S3,
                        4 => S4,
                        5 => S5,
                        6 => S6,
                        7 => S7,
                        8 => S8,
                        _ => S1
                    };
                    c = getNearestColor(c, tempList);
                    originalImage.SetPixel(i, j, c);
                }
            }
        }

        private void updateOriginalImage()
        {
            progressBar1.Value = 0;
            if (reduceColorsCheckbox.Checked)
            {
                reduceColors(realOriginalImage, k);
            } else
            {
                originalImage = new Bitmap(realOriginalImage);
            }


            Rectangle rect = new Rectangle(0, 0, originalImage.Width, originalImage.Height);

            BitmapData bmpData =
                originalImage.LockBits(rect, ImageLockMode.ReadOnly,
                originalImage.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.

            int bytes = Math.Abs(bmpData.Stride) * originalImage.Height;
            originalImageBytes = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, originalImageBytes, 0, bytes);
            originalImage.UnlockBits(bmpData);
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                loadImageFromFileName(fileDialog.FileName);
            }
        }

        private void loadImageFromFileName(string fileName)
        {
            if (realOriginalImage != null)
            {
                cyanLayer.Dispose();
                magentaLayer.Dispose();
                yellowLayer.Dispose();
                blackLayer.Dispose();
                realOriginalImage.Dispose();
                originalImage.Dispose();
            }

            using (Bitmap tmpBitmap = new Bitmap(fileName))
            {
                realOriginalImage = new Bitmap(tmpBitmap);
            }

            cyanLayer = new Bitmap(realOriginalImage.Width, realOriginalImage.Height, PixelFormat.Format32bppRgb);
            magentaLayer = new Bitmap(realOriginalImage.Width, realOriginalImage.Height, PixelFormat.Format32bppRgb);
            yellowLayer = new Bitmap(realOriginalImage.Width, realOriginalImage.Height, PixelFormat.Format32bppRgb);
            blackLayer = new Bitmap(realOriginalImage.Width, realOriginalImage.Height, PixelFormat.Format32bppRgb);


            updateOriginalImage();

            redrawImages();
        }

        private void copyLayerData(Bitmap layer, Byte[] bytes)
        {
            BitmapData bmpData = layer.LockBits(
                   new Rectangle(0, 0, layer.Width, layer.Height),
                   ImageLockMode.WriteOnly, layer.PixelFormat);

            //Copy the data from the byte array into BitmapData.Scan0
            System.Runtime.InteropServices.Marshal.Copy(bytes, 0, bmpData.Scan0, bytes.Length);

            layer.UnlockBits(bmpData);
        }

        private void setLayerPixel(Color c, Byte[] bytes, int i)
        {
            bytes[i] = c.B;
            bytes[i + 1] = c.G;
            bytes[i + 2] = c.R;
        }

        private void allPicturesButton_Click(object sender, EventArgs e)
        {
            SeparatedColorsForm separatedColorsForm = new SeparatedColorsForm();

            separatedColorsForm.setImages(cyanLayer, magentaLayer, yellowLayer, blackLayer);

            separatedColorsForm.Show();
        }

        private void updateSelectedCurve(CurveColor curveType)
        {
            selectedCurveColor = curveType;

            grabbing = false;
            selectedPoint = -1;
            bezierGraphPictureBox.Refresh();
        }

        private void cyanCurveRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (cyanCurveRadio.Checked)
            {
                updateSelectedCurve(CurveColor.Cyan);
            }
        }

        private void magentaCurveRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (magentaCurveRadio.Checked)
            {
                updateSelectedCurve(CurveColor.Magenta);
            }
        }

        private void yellowCurveRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowCurveRadio.Checked)
            {
                updateSelectedCurve(CurveColor.Yellow);
            }
        }

        private void blackCurveRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (blackCurveRadio.Checked)
            {
                updateSelectedCurve(CurveColor.Black);
            }
        }

        private void bezierGraphPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PointF translatedPoint = Painter.GraphicsToBezierPoint(e.Location, bezierGraphPictureBox.Width, bezierGraphPictureBox.Height, bezierGridMargin);

            CubicCurve curve = selectedCurveColor switch {
                CurveColor.Cyan => cmykConverter.CurveC,
                CurveColor.Magenta => cmykConverter.CurveM,
                CurveColor.Yellow => cmykConverter.CurveY,
                CurveColor.Black => cmykConverter.CurveK,
                _ => cmykConverter.CurveK,
            };

            if (grabbing)
            {
                float newY = Math.Max(Math.Min(translatedPoint.Y, 1), 0);
                float newX;

                float eps = 1e-30f;

                if (selectedPoint == 0)
                {
                    newX = 0;
                }
                else if (selectedPoint == curve.Length - 1)
                {
                    newX = 1;
                }
                else
                {
                    newX = Math.Max(Math.Min(translatedPoint.X, 1 - eps), eps);
                }
                curve[selectedPoint] = new PointF(newX, newY);
                bezierGraphPictureBox.Refresh();
            }
            else
            {
                int lastSelectedPoint = selectedPoint;

                updatePointHover(curve, translatedPoint);

                if (selectedPoint != lastSelectedPoint)
                    bezierGraphPictureBox.Refresh();
            }

        }

        private void updatePointHover(CubicCurve curve, PointF p)
        {
            float translatedRadiusSqr = pointRadius / (float)bezierGraphPictureBox.Width;
            translatedRadiusSqr *= translatedRadiusSqr;

            selectedPoint = -1;
            for (int i = 0; i < curve.Length; i++)
            {
                PointF curvePoint = curve[i];
                float dy = curvePoint.Y - p.Y;
                float dx = curvePoint.X - p.X;
                if (dy * dy + dx * dx < translatedRadiusSqr)
                {
                    selectedPoint = i;
                    break;
                }
            }
        }

        private void bezierGraphPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedPoint != -1)
            {
                grabbing = true;
            }
        }

        private void bezierGraphPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (grabbing)
            {
                if(redrawCheckbox.Checked)
                    redrawImages();

                grabbing = false;
            }

            PointF translatedPoint = Painter.GraphicsToBezierPoint(e.Location, bezierGraphPictureBox.Width, bezierGraphPictureBox.Height, bezierGridMargin);

            CubicCurve curve = selectedCurveColor switch
            {
                CurveColor.Cyan => cmykConverter.CurveC,
                CurveColor.Magenta => cmykConverter.CurveM,
                CurveColor.Yellow => cmykConverter.CurveY,
                CurveColor.Black => cmykConverter.CurveK,
                _ => cmykConverter.CurveK,
            };

            int lastSelectedPoint = selectedPoint;

            updatePointHover(curve, translatedPoint);

            if (lastSelectedPoint != selectedPoint)
            {
                bezierGraphPictureBox.Refresh();
            }
        }

        private void redrawImages()
        {
            if (realOriginalImage != null)
            {
                updateCmykLayers();

                refreshImagePictureBox();
            }
        }

        private void redrawButton_Click(object sender, EventArgs e)
        {
            redrawImages();
        }

        private void saveCurvesButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "XML files(.xml)|*.xml|All files (*.*)|*.*",
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(CMYKConverter));

                using (var writer = dialog.OpenFile())
                {
                    serializer.WriteObject(writer, cmykConverter);
                }
            }
        }

        private void loadCurvesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "XML files(.xml)|*.xml|All files (*.*)|*.*",
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = dialog.OpenFile())
                {
                    loadCurvesFromStream(writer);
                }

            }
        }

        private void loadCurvesFromStream(Stream stream)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(CMYKConverter));

            try
            {
                cmykConverter = (CMYKConverter)serializer.ReadObject(stream);
                bezierGraphPictureBox.Refresh();
                redrawImages();
            }
            catch
            {
                MessageBox.Show("Incorrect .xml file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void noColorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            redrawImages();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void refreshImagePictureBox()
        {
            if (originalImageRadio.Checked)
            {
                imagePictureBox.Image = originalImage;
            }
            else if (cyanImageRadio.Checked)
            {
                imagePictureBox.Image = cyanLayer;
            }
            else if (magentaImageRadio.Checked)
            {
                imagePictureBox.Image = magentaLayer;
            }
            else if (yellowImageRadio.Checked)
            {
                imagePictureBox.Image = yellowLayer;
            }
            else if (blackImageRadio.Checked)
            {
                imagePictureBox.Image = blackLayer;
            }
        }

        private void originalImageRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (originalImageRadio.Checked)
                refreshImagePictureBox();
        }

        private void magentaImageRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (magentaImageRadio.Checked)
                refreshImagePictureBox();
        }

        private void yellowImageRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowImageRadio.Checked)
                refreshImagePictureBox();
        }

        private void blackImageRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (blackImageRadio.Checked)
                refreshImagePictureBox();
        }

        private void cyanImageRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (cyanImageRadio.Checked)
                refreshImagePictureBox();
        }

        private void savePicturesButton_Click(object sender, EventArgs e)
        {
            if(realOriginalImage != null)
            {
                SaveFileDialog fileDialog = new SaveFileDialog
                {
                    Filter = "Image Files(*.png)|*.png"
                };

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string blackAndWhite = noColorCheckbox.Checked ? "blackAndWhite_" : "";
                    Debug.WriteLine(fileDialog.FileName);

                    string fileName = Path.GetFileName(fileDialog.FileName);
                    string path = Path.GetDirectoryName(fileDialog.FileName);

                    cyanLayer.Save($"{path}\\__cyan_{blackAndWhite}{fileName}", ImageFormat.Png);
                    magentaLayer.Save($"{path}\\__magenta_{blackAndWhite}{fileName}", ImageFormat.Png);
                    yellowLayer.Save($"{path}\\__yellow_{blackAndWhite}{fileName}", ImageFormat.Png);
                    blackLayer.Save($"{path}\\__black_{blackAndWhite}{fileName}", ImageFormat.Png);

                }
            }
            
        }

        private void showAllCurvesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bezierGraphPictureBox.Refresh();
        }

        private void loadCurvesFromFilePath(string path)
        {
            using (var writer = File.Open(path, FileMode.Open))
            {
                loadCurvesFromStream(writer);
            }
        }

        private void gcrButton_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Curves\\GCR.xml");

            loadCurvesFromFilePath(path);
        }

        private void ucrButton_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Curves\\UCR.xml");
            loadCurvesFromFilePath(path);
        }

        private void withdrawal0Button_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Curves\\Withdrawal0.xml");
            loadCurvesFromFilePath(path);
        }

        private void withdrawal100Button_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Curves\\Withdrawal100.xml");
            loadCurvesFromFilePath(path);
        }

        private void reduceColorsCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            if(realOriginalImage != null)
            {
                updateOriginalImage();
                redrawImages();
            }
        }

        private void kNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            k = (int)kNumericUpDown.Value;
            if (realOriginalImage != null)
            {
                updateOriginalImage();
                redrawImages();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Images\\Mountain.jpg");

            loadImageFromFileName(path);
        }

        private void imagePictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

            
        }
    }
}
