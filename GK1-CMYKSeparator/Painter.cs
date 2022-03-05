using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace GK1_P3_komoszynskil
{
    static class Painter
    {

        public static Point BezierPointToGraphics(PointF p, int width, int height, float margin)
        {

            float x = p.X;
            float y = 1 - p.Y;
            float gridWidth = width - margin * 2;
            float gridHeight = height- margin * 2;

            return new Point((int)(x * gridWidth + margin), (int)(y * gridHeight + margin));
        }

        public static PointF GraphicsToBezierPoint(Point p, int width, int height, float margin)
        {
            float gridWidth = width - margin * 2;
            float gridHeight = height - margin * 2;

            float x = p.X - margin;
            float y = height - p.Y - margin;
            return new PointF(x / (float)gridWidth, y / (float)gridHeight);
        }
        public static void DrawGrayRamp(Graphics g, CMYKConverter cmykConverter, int width, int height, CurveColor selectedCurveType, int R, int selectedPoint, float margin, CurveColor? layerType = null)
        {
            float xOffset = margin;
            float yOffset = margin;
            float gridHeight = height - margin * 2;
            float gridWidth = width - margin * 2;


            //draw Grid
            g.DrawLine(Pens.LightGray, xOffset, yOffset + gridHeight / 4, xOffset + gridWidth, yOffset + gridHeight / 4);
            g.DrawLine(Pens.LightGray, xOffset, yOffset + gridHeight / 2, xOffset + gridWidth, yOffset + gridHeight / 2);
            g.DrawLine(Pens.LightGray, xOffset, yOffset + gridHeight * 3 / 4, xOffset + gridWidth, yOffset + gridHeight * 3 / 4);

            g.DrawLine(Pens.LightGray, xOffset + gridWidth / 4, yOffset, xOffset + gridWidth / 4, gridHeight + yOffset);
            g.DrawLine(Pens.LightGray, xOffset + gridWidth / 2, yOffset, xOffset + gridWidth / 2, gridHeight + yOffset);
            g.DrawLine(Pens.LightGray, xOffset + gridWidth * 3 / 4, yOffset, xOffset + gridWidth * 3 / 4, gridHeight + yOffset);


            g.DrawLine(Pens.Black, xOffset, yOffset, gridWidth + xOffset, yOffset);
            g.DrawLine(Pens.Black, xOffset, yOffset + gridHeight, xOffset + gridWidth, yOffset + gridHeight);
            g.DrawLine(Pens.Black, xOffset, yOffset, xOffset, yOffset + gridHeight);
            g.DrawLine(Pens.Black, xOffset + gridWidth, yOffset, xOffset + gridWidth, yOffset + gridHeight);


            // draw curves

            if(layerType == null || layerType == CurveColor.Cyan)
            {
                g.DrawBezier(Pens.DarkCyan,
                    BezierPointToGraphics(cmykConverter.CurveC.p1, width, height, margin), BezierPointToGraphics(cmykConverter.CurveC.p2, width, height, margin),
                    BezierPointToGraphics(cmykConverter.CurveC.p3, width, height, margin), BezierPointToGraphics(cmykConverter.CurveC.p4, width, height, margin));
            }

            if (layerType == null || layerType == CurveColor.Magenta)
            {
                g.DrawBezier(Pens.Magenta,
                BezierPointToGraphics(cmykConverter.CurveM.p1, width, height, margin), BezierPointToGraphics(cmykConverter.CurveM.p2, width, height, margin),
                BezierPointToGraphics(cmykConverter.CurveM.p3, width, height, margin), BezierPointToGraphics(cmykConverter.CurveM.p4, width, height, margin));
            }
                
            if (layerType == null || layerType == CurveColor.Yellow)
            {
                g.DrawBezier(Pens.Gold,
                BezierPointToGraphics(cmykConverter.CurveY.p1, width, height, margin), BezierPointToGraphics(cmykConverter.CurveY.p2, width, height, margin),
                BezierPointToGraphics(cmykConverter.CurveY.p3, width, height, margin), BezierPointToGraphics(cmykConverter.CurveY.p4, width, height, margin));
            }


            if (layerType == null || layerType == CurveColor.Black)
            {
                g.DrawBezier(Pens.Black,
                BezierPointToGraphics(cmykConverter.CurveK.p1, width, height, margin), BezierPointToGraphics(cmykConverter.CurveK.p2, width, height, margin),
                BezierPointToGraphics(cmykConverter.CurveK.p3, width, height, margin), BezierPointToGraphics(cmykConverter.CurveK.p4, width, height, margin));
            }

            CubicCurve curve;
            Pen pointPen;
            switch (selectedCurveType)
            {
                case CurveColor.Cyan:
                    curve = cmykConverter.CurveC;
                    pointPen = Pens.DarkCyan;
                    break;
                case CurveColor.Magenta:
                    curve = cmykConverter.CurveM;
                    pointPen = Pens.Magenta;
                    break;
                case CurveColor.Yellow:
                    curve = cmykConverter.CurveY;
                    pointPen = Pens.Gold;
                    break;
                case CurveColor.Black:
                default:
                    curve = cmykConverter.CurveK;
                    pointPen = Pens.Black;
                    break;
            }

            for(int i = 0; i < curve.Length; i++)
            {
                PointF p = curve[i];
                Point translatedPoint = BezierPointToGraphics(p, width, height, margin);
                if(selectedPoint == i)
                {
                    g.FillEllipse(pointPen.Brush, translatedPoint.X - R, translatedPoint.Y - R, R * 2, R * 2);
                } else
                {
                    g.DrawEllipse(pointPen, translatedPoint.X - R, translatedPoint.Y - R, R * 2, R * 2);
                }
            }
        }
    }
}
