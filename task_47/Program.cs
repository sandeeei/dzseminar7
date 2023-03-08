// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    for (int m = 0; m < rows; m++)
    {
        for (int n = 0; n < cols; n++)
        {
            matrix[m, n] = Math.Round(100 * (new Random().NextDouble()), 2);
        }
       
    }
     return matrix; 
}   

    void PrintMatrix(double[,] matr) // Печатаем двумерный массив
    {
        for (int m = 0; m < matr.GetLength(0); m++)
        {
            for (int n = 0; n < matr.GetLength(1); n++)
            {
                Console.Write(matr[m, n] + "\t");
            }
            Console.WriteLine();
        }
    }


    double[,] resultMatrix = GetMatrix(3, 4);
    PrintMatrix(resultMatrix);
