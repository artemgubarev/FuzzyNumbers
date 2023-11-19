using System;
using System.Collections.Generic;
using System.Linq;

namespace FuzzyNumbers
{
    internal class ArrayComparer<T> : IEqualityComparer<T[]>
    {
        private readonly Func<T[], T> _elementSelector;

        public ArrayComparer(Func<T[], T> elementSelector)
        {
            _elementSelector = elementSelector ?? throw new ArgumentNullException(nameof(elementSelector));
        }

        public bool Equals(T[] x, T[] y)
        {
            // Сравниваем только выбранный элемент
            return EqualityComparer<T>.Default.Equals(_elementSelector(x), _elementSelector(y));
        }

        public int GetHashCode(T[] obj)
        {
            // Генерируем хэш-код только для выбранного элемента
            return EqualityComparer<T>.Default.GetHashCode(_elementSelector(obj));
        }
    }

    internal class FuzzyNumbersCalculator
    {
        internal static IEnumerable<double[]> ExecuteOperation(IEnumerable<double[]> A, IEnumerable<double[]> B,string operation)
        {
            var comparer = new ArrayComparer<double>(x => x[0]);
            var levelsOnlyInA = A.Except(B, comparer);
            var levelsOnlyInB = B.Except(A, comparer);

            A = AddLevels(A, levelsOnlyInB);
            B = AddLevels(B, levelsOnlyInA);

           var operations = new Dictionary<string, Func<double, double, double>>()
                {
                {"+", (x,y) => x+y },
                {"-", (x,y) => x-y },
                {"/", (x,y) => x/y },
                {"*", (x,y) => x*y },
                };

            var results = ExecuteOperation(A, B, operations[operation]);
            return results;
        }

        private static IEnumerable<double[]> ExecuteOperation(IEnumerable<double[]> A, IEnumerable<double[]> B,  Func<double, double, double> operation)
        {
            var a = A.ToArray();
            var b = B.ToArray();
            int length = a.GetLength(0);
            var c = new double[length][];
            for (int i = 0; i < length; i++)
            {
                // alpha, нижняя, верхняя
                var result = new double[3];
                result[0] = a[i][0];
                result[1] = operation(a[i][1], b[i][1]);
                result[2] = operation(a[i][2], b[i][2]);
                c[i] = result;
            }
            return c;
        }

        internal static IEnumerable<string> Compare(IEnumerable<double[]> A, IEnumerable<double[]> B)
        {
            var a = A.ToArray();
            var b = B.ToArray();
            double sumA = 0; 
            double sumB = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sumA += a[i][1] + a[i][2];
            }
            for (int i = 0; i < b.Length; i++)
            {
                sumB += b[i][1] + b[i][2];
            }
            sumA /= a.Length;
            sumB /= b.Length;
            var result = new List<string>();
            if (sumA == sumB)
            {
                result.AddRange(new[] { "=", ">=", "<=" });
            }
            else
            {
                if (sumA > sumB)
                {
                    result.AddRange(new[] { ">", "!=", ">=" });
                }
                else
                {
                    result.AddRange(new[] { "<", "!=", "<=" });
                }
            }
            return result;
        }

        private static IEnumerable<double[]> AddLevels(IEnumerable<double[]> matrix, IEnumerable<double[]> newRows)
        {
            var matrixList = matrix.ToList();
            foreach (var row in newRows)
            {
                double level = row[0];

                double x1 = matrixList[0][1];
                double y1 = matrixList[0][0];
                double x2 = matrixList[1][1];
                double y2 = matrixList[1][0];

                double newXleft;
                double newXright;

                newXleft = Inter(x1, y1, x2, y2, level);
                x1 = matrixList[0][2];
                y1 = matrixList[0][0];
                x2 = matrixList[1][2];
                y2 = matrixList[1][0];

                newXright = Inter(x1, y1, x2, y2, level);

                matrixList.Add(new double[] { level, newXleft, newXright });
            }

            return matrixList;
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
