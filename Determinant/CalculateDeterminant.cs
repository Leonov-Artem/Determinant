using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinant
{
    class CalculateDeterminant
    {
        private double[] matrix;
        private int Dimension { get; set; }

        public CalculateDeterminant(double[] matrix)
        {
            this.matrix = matrix;
            Dimension = matrix.Rank;
        }
    }
}
