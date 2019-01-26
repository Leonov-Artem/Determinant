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

        public double[,] Minor(double[,] matrix, int x, int y)
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
