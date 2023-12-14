//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
    int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
 int rows = 3;
 int cols = 4;
int[,] matrix = GenerateMatrix(rows, cols, 10, 100);
Console.WriteLine();

int minSumLine = 0;
int sumLine = SumLine(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSumLine = SumLine(matrix, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
minSumLine = minSumLine + 1;
 Printmatrix(matrix);
Console.WriteLine("Строка с наименьшей суммой равна: " + minSumLine);
Console.WriteLine("Наименьшая сумма равна: " + sumLine);

 
