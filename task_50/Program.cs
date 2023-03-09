//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1(строчка) 7 (столбец) -> такого числа в массиве нет


int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {

        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(100);
        }
    }
    return matrix;
}
void PrintIndex(int[,] matr)
{
    Console.Write("Введите строку:");
    int line = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите столбец:");
    int col = Convert.ToInt32(Console.ReadLine()) - 1;


    if (line < 0 || line > matr.GetLength(0) - 1 || col < 0 || col > matr.GetLength(1) - 1)
    {

        Console.WriteLine("Элемент с данными индексами   в данном массиве отсутствует");
    }
    else
    {
        Console.WriteLine($"Элемент с данными индексами = {matr[line, col]}");
    }

}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

PrintMatrix(GetMatrix(5, 5));
PrintIndex(GetMatrix(5, 5));
