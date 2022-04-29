using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class MatrixTest
    {
        private int _diagm;
        private int _diags;


        public void GenerateMatrix()
        {
            Console.WriteLine("The matrix is:");
        }

        public void GenerateMatrix(int[,] matrixOfIntegers)
        { 
            for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                {
                    Console.Write(matrixOfIntegers[i, j] + "     ");
                }
                Console.WriteLine();
            }
        }

        public int GetSummOfMainDiagonalsElements(int[,] matrixOfIntegers)
        {
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {

                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if (i == j)
                            _diagm += matrixOfIntegers[i, j];
                    }

                }
                Console.WriteLine("First Diagonal sum is: " + _diagm);
            }
            else Console.WriteLine("This matrix doesn't have a main diagonals");
            return _diagm;
        }

        public int GetSummOfSecondDiagonalsElements(int[,] matrixOfIntegers)
        {
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {

                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if ((i + j) == (matrixOfIntegers.GetLength(1) - 1))
                            _diags += matrixOfIntegers[i, j];
                    }

                }
                Console.WriteLine("Second Diagonal sum is: " + _diags);
            }
            else Console.WriteLine("This matrix doesn't have a second diagonals");
            return _diags;
        }


    }
}
