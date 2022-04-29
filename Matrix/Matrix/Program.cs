using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix1 = new int[3, 5] {
                { 1,   3,  5,   6, 1},
                { 2,   3,  5,  78, 1},
                {100, 56 , -54, 6, 1} };
            
            MatrixTest myMatrix = new MatrixTest();
            myMatrix.GenerateMatrix();
            myMatrix.GenerateMatrix(matrix);
            
            myMatrix.GetSummOfMainDiagonalsElements(matrix);
            myMatrix.GetSummOfSecondDiagonalsElements(matrix);

            myMatrix.GenerateMatrix();
            myMatrix.GenerateMatrix(matrix1);

            myMatrix.GetSummOfMainDiagonalsElements(matrix1);
            myMatrix.GetSummOfSecondDiagonalsElements(matrix1);
        }
    }
}
