
namespace GK1_P3_komoszynskil
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bezierGraphPictureBox = new System.Windows.Forms.PictureBox();
            this.variablesGroupBox = new System.Windows.Forms.GroupBox();
            this.redrawCheckbox = new System.Windows.Forms.CheckBox();
            this.ucrButton = new System.Windows.Forms.Button();
            this.gcrButton = new System.Windows.Forms.Button();
            this.withdrawal100Button = new System.Windows.Forms.Button();
            this.withdrawal0Button = new System.Windows.Forms.Button();
            this.showAllCurvesCheckBox = new System.Windows.Forms.CheckBox();
            this.blackCurveRadio = new System.Windows.Forms.RadioButton();
            this.loadCurvesButton = new System.Windows.Forms.Button();
            this.yellowCurveRadio = new System.Windows.Forms.RadioButton();
            this.magentaCurveRadio = new System.Windows.Forms.RadioButton();
            this.saveCurvesButton = new System.Windows.Forms.Button();
            this.cyanCurveRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.reduceColorsCheckbox = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.visibleImageGroupBox = new System.Windows.Forms.GroupBox();
            this.originalImageRadio = new System.Windows.Forms.RadioButton();
            this.blackImageRadio = new System.Windows.Forms.RadioButton();
            this.yellowImageRadio = new System.Windows.Forms.RadioButton();
            this.magentaImageRadio = new System.Windows.Forms.RadioButton();
            this.cyanImageRadio = new System.Windows.Forms.RadioButton();
            this.noColorCheckbox = new System.Windows.Forms.CheckBox();
            this.savePicturesButton = new System.Windows.Forms.Button();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.allPicturesButton = new System.Windows.Forms.Button();
            this.redrawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bezierGraphPictureBox)).BeginInit();
            this.variablesGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).BeginInit();
            this.visibleImageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(928, 512);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.bezierGraphPictureBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.variablesGroupBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(308, 512);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // bezierGraphPictureBox
            // 
            this.bezierGraphPictureBox.BackColor = System.Drawing.Color.White;
            this.bezierGraphPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bezierGraphPictureBox.Location = new System.Drawing.Point(3, 3);
            this.bezierGraphPictureBox.Name = "bezierGraphPictureBox";
            this.bezierGraphPictureBox.Size = new System.Drawing.Size(302, 302);
            this.bezierGraphPictureBox.TabIndex = 0;
            this.bezierGraphPictureBox.TabStop = false;
            this.bezierGraphPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.bezierGraphPictureBox_Paint);
            this.bezierGraphPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bezierGraphPictureBox_MouseDown);
            this.bezierGraphPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bezierGraphPictureBox_MouseMove);
            this.bezierGraphPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bezierGraphPictureBox_MouseUp);
            // 
            // variablesGroupBox
            // 
            this.variablesGroupBox.Controls.Add(this.redrawCheckbox);
            this.variablesGroupBox.Controls.Add(this.ucrButton);
            this.variablesGroupBox.Controls.Add(this.gcrButton);
            this.variablesGroupBox.Controls.Add(this.withdrawal100Button);
            this.variablesGroupBox.Controls.Add(this.withdrawal0Button);
            this.variablesGroupBox.Controls.Add(this.showAllCurvesCheckBox);
            this.variablesGroupBox.Controls.Add(this.blackCurveRadio);
            this.variablesGroupBox.Controls.Add(this.loadCurvesButton);
            this.variablesGroupBox.Controls.Add(this.yellowCurveRadio);
            this.variablesGroupBox.Controls.Add(this.magentaCurveRadio);
            this.variablesGroupBox.Controls.Add(this.saveCurvesButton);
            this.variablesGroupBox.Controls.Add(this.cyanCurveRadio);
            this.variablesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variablesGroupBox.Location = new System.Drawing.Point(3, 311);
            this.variablesGroupBox.Name = "variablesGroupBox";
            this.variablesGroupBox.Size = new System.Drawing.Size(302, 198);
            this.variablesGroupBox.TabIndex = 1;
            this.variablesGroupBox.TabStop = false;
            this.variablesGroupBox.Text = "Curves Manage";
            // 
            // redrawCheckbox
            // 
            this.redrawCheckbox.AutoSize = true;
            this.redrawCheckbox.Checked = true;
            this.redrawCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redrawCheckbox.Location = new System.Drawing.Point(9, 152);
            this.redrawCheckbox.Name = "redrawCheckbox";
            this.redrawCheckbox.Size = new System.Drawing.Size(167, 19);
            this.redrawCheckbox.TabIndex = 13;
            this.redrawCheckbox.Text = "Recalculate on point move";
            this.redrawCheckbox.UseVisualStyleBackColor = true;
            // 
            // ucrButton
            // 
            this.ucrButton.Location = new System.Drawing.Point(221, 65);
            this.ucrButton.Name = "ucrButton";
            this.ucrButton.Size = new System.Drawing.Size(75, 23);
            this.ucrButton.TabIndex = 12;
            this.ucrButton.Text = "UCR";
            this.ucrButton.UseVisualStyleBackColor = true;
            this.ucrButton.Click += new System.EventHandler(this.ucrButton_Click);
            // 
            // gcrButton
            // 
            this.gcrButton.Location = new System.Drawing.Point(121, 64);
            this.gcrButton.Name = "gcrButton";
            this.gcrButton.Size = new System.Drawing.Size(75, 23);
            this.gcrButton.TabIndex = 11;
            this.gcrButton.Text = "GCR";
            this.gcrButton.UseVisualStyleBackColor = true;
            this.gcrButton.Click += new System.EventHandler(this.gcrButton_Click);
            // 
            // withdrawal100Button
            // 
            this.withdrawal100Button.AutoSize = true;
            this.withdrawal100Button.Location = new System.Drawing.Point(190, 134);
            this.withdrawal100Button.Name = "withdrawal100Button";
            this.withdrawal100Button.Size = new System.Drawing.Size(106, 25);
            this.withdrawal100Button.TabIndex = 10;
            this.withdrawal100Button.Text = "100% withdrawal";
            this.withdrawal100Button.UseVisualStyleBackColor = true;
            this.withdrawal100Button.Click += new System.EventHandler(this.withdrawal100Button_Click);
            // 
            // withdrawal0Button
            // 
            this.withdrawal0Button.AutoSize = true;
            this.withdrawal0Button.Location = new System.Drawing.Point(202, 99);
            this.withdrawal0Button.Name = "withdrawal0Button";
            this.withdrawal0Button.Size = new System.Drawing.Size(94, 25);
            this.withdrawal0Button.TabIndex = 9;
            this.withdrawal0Button.Text = "0% withdrawal";
            this.withdrawal0Button.UseVisualStyleBackColor = true;
            this.withdrawal0Button.Click += new System.EventHandler(this.withdrawal0Button_Click);
            // 
            // showAllCurvesCheckBox
            // 
            this.showAllCurvesCheckBox.AutoSize = true;
            this.showAllCurvesCheckBox.Checked = true;
            this.showAllCurvesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAllCurvesCheckBox.Location = new System.Drawing.Point(9, 127);
            this.showAllCurvesCheckBox.Name = "showAllCurvesCheckBox";
            this.showAllCurvesCheckBox.Size = new System.Drawing.Size(107, 19);
            this.showAllCurvesCheckBox.TabIndex = 6;
            this.showAllCurvesCheckBox.Text = "Show all curves";
            this.showAllCurvesCheckBox.UseVisualStyleBackColor = true;
            this.showAllCurvesCheckBox.CheckedChanged += new System.EventHandler(this.showAllCurvesCheckBox_CheckedChanged);
            // 
            // blackCurveRadio
            // 
            this.blackCurveRadio.AutoSize = true;
            this.blackCurveRadio.Location = new System.Drawing.Point(9, 102);
            this.blackCurveRadio.Name = "blackCurveRadio";
            this.blackCurveRadio.Size = new System.Drawing.Size(53, 19);
            this.blackCurveRadio.TabIndex = 5;
            this.blackCurveRadio.Text = "Black";
            this.blackCurveRadio.UseVisualStyleBackColor = true;
            this.blackCurveRadio.CheckedChanged += new System.EventHandler(this.blackCurveRadio_CheckedChanged);
            // 
            // loadCurvesButton
            // 
            this.loadCurvesButton.AutoSize = true;
            this.loadCurvesButton.Location = new System.Drawing.Point(214, 28);
            this.loadCurvesButton.Name = "loadCurvesButton";
            this.loadCurvesButton.Size = new System.Drawing.Size(82, 25);
            this.loadCurvesButton.TabIndex = 8;
            this.loadCurvesButton.Text = "Load Curves";
            this.loadCurvesButton.UseVisualStyleBackColor = true;
            this.loadCurvesButton.Click += new System.EventHandler(this.loadCurvesButton_Click);
            // 
            // yellowCurveRadio
            // 
            this.yellowCurveRadio.AutoSize = true;
            this.yellowCurveRadio.Location = new System.Drawing.Point(9, 77);
            this.yellowCurveRadio.Name = "yellowCurveRadio";
            this.yellowCurveRadio.Size = new System.Drawing.Size(59, 19);
            this.yellowCurveRadio.TabIndex = 4;
            this.yellowCurveRadio.Text = "Yellow";
            this.yellowCurveRadio.UseVisualStyleBackColor = true;
            this.yellowCurveRadio.CheckedChanged += new System.EventHandler(this.yellowCurveRadio_CheckedChanged);
            // 
            // magentaCurveRadio
            // 
            this.magentaCurveRadio.AutoSize = true;
            this.magentaCurveRadio.Location = new System.Drawing.Point(9, 53);
            this.magentaCurveRadio.Name = "magentaCurveRadio";
            this.magentaCurveRadio.Size = new System.Drawing.Size(72, 19);
            this.magentaCurveRadio.TabIndex = 3;
            this.magentaCurveRadio.Text = "Magenta";
            this.magentaCurveRadio.UseVisualStyleBackColor = true;
            this.magentaCurveRadio.CheckedChanged += new System.EventHandler(this.magentaCurveRadio_CheckedChanged);
            // 
            // saveCurvesButton
            // 
            this.saveCurvesButton.AutoSize = true;
            this.saveCurvesButton.Location = new System.Drawing.Point(116, 28);
            this.saveCurvesButton.Name = "saveCurvesButton";
            this.saveCurvesButton.Size = new System.Drawing.Size(80, 25);
            this.saveCurvesButton.TabIndex = 7;
            this.saveCurvesButton.Text = "Save Curves";
            this.saveCurvesButton.UseVisualStyleBackColor = true;
            this.saveCurvesButton.Click += new System.EventHandler(this.saveCurvesButton_Click);
            // 
            // cyanCurveRadio
            // 
            this.cyanCurveRadio.AutoSize = true;
            this.cyanCurveRadio.Checked = true;
            this.cyanCurveRadio.Location = new System.Drawing.Point(9, 28);
            this.cyanCurveRadio.Name = "cyanCurveRadio";
            this.cyanCurveRadio.Size = new System.Drawing.Size(52, 19);
            this.cyanCurveRadio.TabIndex = 2;
            this.cyanCurveRadio.TabStop = true;
            this.cyanCurveRadio.Text = "Cyan";
            this.cyanCurveRadio.UseVisualStyleBackColor = true;
            this.cyanCurveRadio.CheckedChanged += new System.EventHandler(this.cyanCurveRadio_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.imagePictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(610, 302);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 0;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.imagePictureBox_LoadCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kNumericUpDown);
            this.panel1.Controls.Add(this.reduceColorsCheckbox);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.visibleImageGroupBox);
            this.panel1.Controls.Add(this.noColorCheckbox);
            this.panel1.Controls.Add(this.savePicturesButton);
            this.panel1.Controls.Add(this.selectImageButton);
            this.panel1.Controls.Add(this.allPicturesButton);
            this.panel1.Controls.Add(this.redrawButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 198);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "k:";
            // 
            // kNumericUpDown
            // 
            this.kNumericUpDown.Location = new System.Drawing.Point(206, 64);
            this.kNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.kNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.kNumericUpDown.Name = "kNumericUpDown";
            this.kNumericUpDown.Size = new System.Drawing.Size(65, 23);
            this.kNumericUpDown.TabIndex = 14;
            this.kNumericUpDown.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.kNumericUpDown.ValueChanged += new System.EventHandler(this.kNumericUpDown_ValueChanged);
            // 
            // reduceColorsCheckbox
            // 
            this.reduceColorsCheckbox.AutoSize = true;
            this.reduceColorsCheckbox.Location = new System.Drawing.Point(206, 19);
            this.reduceColorsCheckbox.Name = "reduceColorsCheckbox";
            this.reduceColorsCheckbox.Size = new System.Drawing.Size(102, 19);
            this.reduceColorsCheckbox.TabIndex = 13;
            this.reduceColorsCheckbox.Text = "Reduce Colors";
            this.reduceColorsCheckbox.UseVisualStyleBackColor = true;
            this.reduceColorsCheckbox.CheckedChanged += new System.EventHandler(this.reduceColorsCheckbox_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(13, 179);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(587, 10);
            this.progressBar1.TabIndex = 12;
            // 
            // visibleImageGroupBox
            // 
            this.visibleImageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visibleImageGroupBox.Controls.Add(this.originalImageRadio);
            this.visibleImageGroupBox.Controls.Add(this.blackImageRadio);
            this.visibleImageGroupBox.Controls.Add(this.yellowImageRadio);
            this.visibleImageGroupBox.Controls.Add(this.magentaImageRadio);
            this.visibleImageGroupBox.Controls.Add(this.cyanImageRadio);
            this.visibleImageGroupBox.Location = new System.Drawing.Point(362, 3);
            this.visibleImageGroupBox.Name = "visibleImageGroupBox";
            this.visibleImageGroupBox.Size = new System.Drawing.Size(245, 154);
            this.visibleImageGroupBox.TabIndex = 11;
            this.visibleImageGroupBox.TabStop = false;
            this.visibleImageGroupBox.Text = "Visible Image";
            // 
            // originalImageRadio
            // 
            this.originalImageRadio.AutoSize = true;
            this.originalImageRadio.Checked = true;
            this.originalImageRadio.Location = new System.Drawing.Point(13, 24);
            this.originalImageRadio.Name = "originalImageRadio";
            this.originalImageRadio.Size = new System.Drawing.Size(67, 19);
            this.originalImageRadio.TabIndex = 10;
            this.originalImageRadio.TabStop = true;
            this.originalImageRadio.Text = "Original";
            this.originalImageRadio.UseVisualStyleBackColor = true;
            this.originalImageRadio.CheckedChanged += new System.EventHandler(this.originalImageRadio_CheckedChanged);
            // 
            // blackImageRadio
            // 
            this.blackImageRadio.AutoSize = true;
            this.blackImageRadio.Location = new System.Drawing.Point(13, 121);
            this.blackImageRadio.Name = "blackImageRadio";
            this.blackImageRadio.Size = new System.Drawing.Size(53, 19);
            this.blackImageRadio.TabIndex = 9;
            this.blackImageRadio.Text = "Black";
            this.blackImageRadio.UseVisualStyleBackColor = true;
            this.blackImageRadio.CheckedChanged += new System.EventHandler(this.blackImageRadio_CheckedChanged);
            // 
            // yellowImageRadio
            // 
            this.yellowImageRadio.AutoSize = true;
            this.yellowImageRadio.Location = new System.Drawing.Point(13, 96);
            this.yellowImageRadio.Name = "yellowImageRadio";
            this.yellowImageRadio.Size = new System.Drawing.Size(59, 19);
            this.yellowImageRadio.TabIndex = 8;
            this.yellowImageRadio.Text = "Yellow";
            this.yellowImageRadio.UseVisualStyleBackColor = true;
            this.yellowImageRadio.CheckedChanged += new System.EventHandler(this.yellowImageRadio_CheckedChanged);
            // 
            // magentaImageRadio
            // 
            this.magentaImageRadio.AutoSize = true;
            this.magentaImageRadio.Location = new System.Drawing.Point(13, 72);
            this.magentaImageRadio.Name = "magentaImageRadio";
            this.magentaImageRadio.Size = new System.Drawing.Size(72, 19);
            this.magentaImageRadio.TabIndex = 7;
            this.magentaImageRadio.Text = "Magenta";
            this.magentaImageRadio.UseVisualStyleBackColor = true;
            this.magentaImageRadio.CheckedChanged += new System.EventHandler(this.magentaImageRadio_CheckedChanged);
            // 
            // cyanImageRadio
            // 
            this.cyanImageRadio.AutoSize = true;
            this.cyanImageRadio.Location = new System.Drawing.Point(13, 47);
            this.cyanImageRadio.Name = "cyanImageRadio";
            this.cyanImageRadio.Size = new System.Drawing.Size(52, 19);
            this.cyanImageRadio.TabIndex = 6;
            this.cyanImageRadio.Text = "Cyan";
            this.cyanImageRadio.UseVisualStyleBackColor = true;
            this.cyanImageRadio.CheckedChanged += new System.EventHandler(this.cyanImageRadio_CheckedChanged);
            // 
            // noColorCheckbox
            // 
            this.noColorCheckbox.AutoSize = true;
            this.noColorCheckbox.Location = new System.Drawing.Point(15, 138);
            this.noColorCheckbox.Name = "noColorCheckbox";
            this.noColorCheckbox.Size = new System.Drawing.Size(167, 19);
            this.noColorCheckbox.TabIndex = 10;
            this.noColorCheckbox.Text = "Pictures in black and white";
            this.noColorCheckbox.UseVisualStyleBackColor = true;
            this.noColorCheckbox.CheckedChanged += new System.EventHandler(this.noColorCheckbox_CheckedChanged);
            // 
            // savePicturesButton
            // 
            this.savePicturesButton.AutoSize = true;
            this.savePicturesButton.Location = new System.Drawing.Point(13, 76);
            this.savePicturesButton.Name = "savePicturesButton";
            this.savePicturesButton.Size = new System.Drawing.Size(86, 25);
            this.savePicturesButton.TabIndex = 9;
            this.savePicturesButton.Text = "Save Images";
            this.savePicturesButton.UseVisualStyleBackColor = true;
            this.savePicturesButton.Click += new System.EventHandler(this.savePicturesButton_Click);
            // 
            // selectImageButton
            // 
            this.selectImageButton.AutoSize = true;
            this.selectImageButton.Location = new System.Drawing.Point(13, 15);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(84, 25);
            this.selectImageButton.TabIndex = 0;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // allPicturesButton
            // 
            this.allPicturesButton.AutoSize = true;
            this.allPicturesButton.Location = new System.Drawing.Point(13, 46);
            this.allPicturesButton.Name = "allPicturesButton";
            this.allPicturesButton.Size = new System.Drawing.Size(106, 25);
            this.allPicturesButton.TabIndex = 1;
            this.allPicturesButton.Text = "Show All Images";
            this.allPicturesButton.UseVisualStyleBackColor = true;
            this.allPicturesButton.Click += new System.EventHandler(this.allPicturesButton_Click);
            // 
            // redrawButton
            // 
            this.redrawButton.AutoSize = true;
            this.redrawButton.Location = new System.Drawing.Point(13, 107);
            this.redrawButton.Name = "redrawButton";
            this.redrawButton.Size = new System.Drawing.Size(88, 25);
            this.redrawButton.TabIndex = 6;
            this.redrawButton.Text = "Force Redraw";
            this.redrawButton.UseVisualStyleBackColor = true;
            this.redrawButton.Click += new System.EventHandler(this.redrawButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 512);
            this.Controls.Add(this.splitContainer1);
            this.Name = "mainForm";
            this.Text = "GK1 CMYK Separator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bezierGraphPictureBox)).EndInit();
            this.variablesGroupBox.ResumeLayout(false);
            this.variablesGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).EndInit();
            this.visibleImageGroupBox.ResumeLayout(false);
            this.visibleImageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox bezierGraphPictureBox;
        private System.Windows.Forms.GroupBox variablesGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button allPicturesButton;
        private System.Windows.Forms.RadioButton blackCurveRadio;
        private System.Windows.Forms.RadioButton yellowCurveRadio;
        private System.Windows.Forms.RadioButton magentaCurveRadio;
        private System.Windows.Forms.RadioButton cyanCurveRadio;
        private System.Windows.Forms.Button redrawButton;
        private System.Windows.Forms.Button saveCurvesButton;
        private System.Windows.Forms.Button loadCurvesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox showAllCurvesCheckBox;
        private System.Windows.Forms.CheckBox noColorCheckbox;
        private System.Windows.Forms.Button savePicturesButton;
        private System.Windows.Forms.GroupBox visibleImageGroupBox;
        private System.Windows.Forms.RadioButton blackImageRadio;
        private System.Windows.Forms.RadioButton yellowImageRadio;
        private System.Windows.Forms.RadioButton magentaImageRadio;
        private System.Windows.Forms.RadioButton cyanImageRadio;
        private System.Windows.Forms.RadioButton originalImageRadio;
        private System.Windows.Forms.Button ucrButton;
        private System.Windows.Forms.Button gcrButton;
        private System.Windows.Forms.Button withdrawal100Button;
        private System.Windows.Forms.Button withdrawal0Button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox redrawCheckbox;
        private System.Windows.Forms.CheckBox reduceColorsCheckbox;
        private System.Windows.Forms.NumericUpDown kNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}

