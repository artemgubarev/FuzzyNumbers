using System;
using System.Collections.Generic;
using System.Linq;

namespace FuzzyNumbers
{
    internal class FuzzyNumbersCalculator
    {
        internal static IEnumerable<double[]> ExecuteOperation(IEnumerable<double[]> A, IEnumerable<double[]> B,string operation)
        {
            var a = A.ToArray();
            var b = B.ToArray();

            var levels = new HashSet<double>();
            var aLevels = new List<double>();
            var bLevels = new List<double>();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                levels.Add(a[i][0]);
                aLevels.Add(a[i][0]);
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                levels.Add(b[i][0]);
                bLevels.Add(b[i][0]);
            }

            foreach (var level in levels)
            {
                if (!aLevels.Contains(level))
                {
                    a = SetLevel(a, level).ToArray();
                }

                if (!bLevels.Contains(level))
                {
                    b = SetLevel(b, level).ToArray();
                }
            }

            if (operation == "+")
            {
                return Plus(a, b);
            }
            if (operation == "-")
            {
                return Minus(a, b);
            }
            if (operation == "*")
            {
                return Mult(a, b);
            }
            if (operation == "/")
            {
                return Div(a, b);
            }

            return null;
        }

        private static IEnumerable<double[]> Plus(IEnumerable<double[]> A, IEnumerable<double[]> B)
        {
            var a = A.ToArray();
            var b = B.ToArray();

            var c = new List<double[]>();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                double[] values = new double[3];
                values[0] = a[i][0];
                values[1] = a[i][1] + b[i][1];
                values[2] = a[i][2] + b[i][2];
                c.Add(values);
            }

            return c;
        }

        private static IEnumerable<double[]> Minus(IEnumerable<double[]> A, IEnumerable<double[]> B)
        {
            var a = A.ToArray();
            var b = B.ToArray();

            var c = new List<double[]>();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                double[] values = new double[3];
                values[0] = a[i][0];
                values[1] = a[i][1] - b[i][1];
                values[2] = a[i][2] - b[i][2];
                c.Add(values);
            }

            return c;
        }

        private static IEnumerable<double[]> Div(IEnumerable<double[]> A, IEnumerable<double[]> B)
        {
            var a = A.ToArray();
            var b = B.ToArray();

            var c = new List<double[]>();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                double[] values = new double[3];
                values[0] = a[i][0];
                values[1] = a[i][1] / b[i][1];
                values[2] = a[i][2] / b[i][2];
                c.Add(values);
            }

            return c;
        }

        private static IEnumerable<double[]> Mult(IEnumerable<double[]> A, IEnumerable<double[]> B)
        {
            var a = A.ToArray();
            var b = B.ToArray();

            var c = new List<double[]>();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                double[] values = new double[3];
                values[0] = a[i][0];
                values[1] = a[i][1] * b[i][1];
                values[2] = a[i][2] * b[i][2];
                c.Add(values);
            }

            return c;
        }

        public static string Compare(IEnumerable<double[]> A, IEnumerable<double[]> B)
        {
            var a = A.ToArray();
            var b = B.ToArray();

            double sumA = 0; double sumB = 0;
            for (int i = 0; i < 3; i++)
            {
                sumA += a[i][1] + a[i][2];

            }
            for (int i = 0; i < 4; i++)
            {
                sumB += b[i][1] + b[i][2];
            }
            sumA = sumA / 3;
            sumB = sumB / 4;
            String result = "";
            if (sumA == sumB) result += "=\n>=\n<=\n";
            else
            {
                if (sumA > sumB) result += ">\n!=\n>=";
                else result += "<\n!=\n<=";
            }

            return "множество A\n" + Convert.ToString(result) + "\nмножество B";
        }

        private static IEnumerable<double[]> SetLevel(IEnumerable<double[]> matrix, double newLevel)
        {
            var set = matrix.ToList();

            double x1 = set[0][1];
            double y1 = set[0][0];
            double x2 = set[1][1];
            double y2 = set[1][0];

            double newXleft;
            double newXright;

            newXleft = Inter(x1, y1, x2, y2, newLevel);
            x1 = set[0][2];
            y1 = set[0][0];
            x2 = set[1][2];
            y2 = set[1][0];

            newXright = Inter(x1, y1, x2, y2, newLevel);

            set.Add(new double[]{newLevel, newXleft, newXright});
            return set;
        }

        private static double Inter(double x1, double y1, double x2, double y2, double newLevel)
        {
            if (x2 == x1) //вертикаль
            {
                return x1;
            }
            else
            {
                double kA = (y2 - y1) / (x2 - x1);
                double bA = -(x1 * y2 - x2 * y1) / (x2 - x1);
                double b2 = newLevel;
                double k2 = 0;

                return (b2 - bA) / (kA - k2);
            }
        }
    }
}
