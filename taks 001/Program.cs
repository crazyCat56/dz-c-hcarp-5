//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
        int Readint(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
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
 int i = Readint("Введите столбец элемента : ");
 int j = Readint("Введите строку элемента : ");

        int[,] matrix = GenerateMatrix(rows, cols, 10, 100);

Console.WriteLine();
    if (i < 0 | j > matrix.GetLength(0) - 1 | j < 0 | j > matrix.GetLength(1) - 1)
    {
   Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = " + matrix[i, j]);
    }
 Printmatrix(matrix);
