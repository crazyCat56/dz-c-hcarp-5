//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GenerateMatrix(int rows, int col, int leftRange, int rightRange)
        {
            int[,] tempMatrix = new int[rows, col];
            Random rand = new Random();
            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
                }
            }
            return tempMatrix;
        }
        void Printmatrix(int[,] matrixForFrint)
        {
            for (int i = 0; i < matrixForFrint.GetLength(0); i++)
            {
                for (int j = 0; j < matrixForFrint.GetLength(1); j++)
                {
                    Console.Write(matrixForFrint[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
 int rows = 7;
 int cols = 7;
int[,] matrix = GenerateMatrix(rows, cols, 10, 100);
 Printmatrix(matrix);
 Console.WriteLine("Поменяли местами первую и последнюю строку массива: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                  int temp = matrix[0,i];
                  matrix[0,i] = matrix[6,i];                                       ///незнаю, temp запоминает одно число потому что int,а в string не переводится 
                  matrix[6,i] = temp;

                 Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }


{
}
                



