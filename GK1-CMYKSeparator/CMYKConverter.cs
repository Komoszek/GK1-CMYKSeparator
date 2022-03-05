using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace GK1_P3_komoszynskil
{
    struct CMYK
    {
        public float C;
        public float M;
        public float Y;
        public float K;

        public CMYK(float c, float m, float y, float k)
        {
            C = c;
            M = m;
            Y = y;
            K = k;
        }
        public Color RGBCyan(bool inBlackAndWhite = false)
        {
            int color = (int)(255 * (1 - C));
            if(inBlackAndWhite)
                return Color.FromArgb(color, color, color);

            return Color.FromArgb(color, 255, 255);
        }

        public Color RGBMagenta(bool inBlackAndWhite = false)
        {
            int color = (int)(255 * (1 - M));

            if (inBlackAndWhite)
                return Color.FromArgb(color, color, color);

            return Color.FromArgb(255, color, 255);
        }

        public Color RGBYellow(bool inBlackAndWhite = false)
        {
            int color = (int)(255 * (1 - Y));

            if (inBlackAndWhite)
                return Color.FromArgb(color, color, color);

            return Color.FromArgb(255, 255, color);
        }

        public Color RGBKeyColor()
        {
            int Kp = (int)(255 * (1 - K));
            return Color.FromArgb(Kp, Kp, Kp);
        }

    }

    [DataContract]
    class CubicCurve
    {
        [DataMember(IsRequired = true)]
        public PointF p1;

        [DataMember(IsRequired = true)]
        public PointF p2;

        [DataMember(IsRequired = true)]
        public PointF p3;

        [DataMember(IsRequired = true)]
        public PointF p4;

        public CubicCurve(PointF p1, PointF p2, PointF p3, PointF p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
        public int Length
        {
            get { return 4; }
        }

        public CubicCurve Clone()
        {
            return (CubicCurve)this.MemberwiseClone();
        }

        public PointF this[int i]
        {
            get
            {
                return i switch
                {
                    0 => p1,
                    1 => p2,
                    2 => p3,
                    3 => p4,
                    _ => throw new ArgumentOutOfRangeException("Index out of range")
                };
            }
            set
            {
                switch (i)
                {
                    case 0:
                        p1 = value;
                        break;
                    case 1:
                        p2 = value;
                        break;
                    case 2:
                        p3 = value;
                        break;
                    case 3:
                        p4 = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Index out of range");
                }
            }

        }
    }

    [DataContract]
    class CMYKConverter
    {
        [DataMember(IsRequired = true)]
        public CubicCurve CurveC;

        [DataMember(IsRequired = true)]
        public CubicCurve CurveM;

        [DataMember(IsRequired = true)]
        public CubicCurve CurveY;

        [DataMember(IsRequired = true)]
        public CubicCurve CurveK;

        public CMYKConverter()
        {
            CubicCurve DefaultCurve = new CubicCurve(new PointF(0, 0), new PointF(1.0f / 3.0f, 1.0f / 3.0f), new PointF(2.0f / 3.0f, 2.0f / 3.0f), new PointF(1.0f, 1.0f));

            CurveC = DefaultCurve.Clone();
            CurveM = DefaultCurve.Clone();
            CurveY = DefaultCurve.Clone();
            CurveK = DefaultCurve.Clone();
        }

        private float GetValueFromCurve(float x, CubicCurve curve)
        {
            // P(t) = A(1-t)^3 + 3Bt(1-t)^2 + 3Ct^2(1-t) + Dt^3
            // x = A_x(1-t)^3 + 3B_xt(1-t)^2 + 3C_xt^2(1-t) + D_xt^3
            // Assume A_x = 0 AND D_x = 1
            // x = 3B_xt(1-t)^2 + 3C_xt^2(1-t) + t^3
            // x = 3b*t(1-2t + t^2) + 3c*t^2(1-t) + t^3
            // x = 3b*t-6bt^2 + 3bt^3 + 3c*t^2-3c*t^3 + t^3
            // x = 3b*t
            // f(t) = (1-3c+3b)t^3 + (3c - 6b)t^2 + 3b*t - x
            // f'(t) = 3(1-3c+3b)t^2 + 2(3c - 6b)t + 3b

            // tn = 0

            float tn = 0.5f;

            float a = (1 - 3 * curve.p3.X + 3 * curve.p2.X);
            float b = (3 * curve.p3.X - 6 * curve.p2.X);
            float c = 3 * curve.p2.X;

            int i = 0;

            float eps = 1e-10f;
            float fv, fvp;

            do
            {
                fv = ((a * tn + b) * tn + c) * tn - x;
                fvp = (3 * a * tn + 2 * b) * tn + c;
                tn -= fv / fvp;
                i++;
            } while (Math.Abs(fv) > eps && i < 50);

            // t (t (t (-A + 3 B - 3 C + D) + 3 A - 6 B + 3 C) - 3 A + 3 B) + A

            float v = tn * (tn*(tn*(-curve.p1.Y + 3*curve.p2.Y - 3*curve.p3.Y + curve.p4.Y) + 3*curve.p1.Y - 6 * curve.p2.Y + 3 * curve.p3.Y) - 3*curve.p1.Y + 3*curve.p2.Y) + curve.p1.Y;

            return v;

        }
        public CMYK FromRGB(Color color)
        {
            float C = 1 - color.R / 255.0f;
            float M = 1 - color.G / 255.0f;
            float Y = 1 - color.B / 255.0f;

            float Kp = Math.Min(C, Math.Min(M, Y));

            C = C - Kp + GetValueFromCurve(Kp, CurveC);
            M = M - Kp + GetValueFromCurve(Kp, CurveM);
            Y = Y - Kp + GetValueFromCurve(Kp, CurveY);
            float K = GetValueFromCurve(Kp, CurveK);

            C = Math.Max(Math.Min(C, 1), 0);
            M = Math.Max(Math.Min(M, 1), 0);
            Y = Math.Max(Math.Min(Y, 1), 0);
            K = Math.Max(Math.Min(K, 1), 0);

            return new CMYK(C, M, Y, K);
        }
    }
}
