using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dim = random.Next(3, 6);

            double[,] matrix = new double[dim, dim];
            FillMatrix(matrix);
            Print(matrix);
            Console.WriteLine();

            CalculateDeterminant determinant = new CalculateDeterminant(matrix);
            double det = determinant.Det();
            Console.WriteLine($"Определитель матрицы = {det}");

            Console.ReadKey();
        }
        static void FillMatrix(double[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(-32, 32); 
            }
            Console.WriteLine();
        }
        static void Print(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0,3} ", matrix[i, j]);
                Console.WriteLine();
            }
        }
    }
}
