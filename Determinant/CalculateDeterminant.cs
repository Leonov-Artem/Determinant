using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinant
{
    class CalculateDeterminant
    {
        private double[,] matrix;
        private int Dimension { get; set; }

        public CalculateDeterminant(double[,] matrix)
        {
            this.matrix = matrix;
            Dimension = matrix.GetLength(0);
        }

        public double Det() => Det(matrix);
        private double Det(double[,] minor, double det=0)
        {
            if (minor.GetLength(0) == 2)
                return minor[0, 0] * minor[1, 1] - minor[0, 1] * minor[1, 0];
            else
            {
                for (int i = 0; i < minor.GetLength(0); i++)
                    det += Math.Pow(-1, i) * minor[0, i] * Det(Minor(minor, 0, i));
            }
            return det;
        }
        private double[,] Minor(double[,] matrix, int x, int y)
        {
            double[,] minor = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

            for (int row = 0, i = 0; row < matrix.GetLength(1); row++)
            {
                if (row != x)
                {
                    for (int col = 0, j = 0; col < matrix.GetLength(1); col++)
                    {
                        if (col != y)
                            minor[i, j++] = matrix[row, col];
                    }
                    i++;
                }
            }

            return minor;
        }
    }
}
