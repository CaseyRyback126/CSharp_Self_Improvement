﻿// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод генерации и заполнения массива
int[,] Fill2DArray(int rows, int cols, int numMin, int numMax)
{
    // Создаём массив
    int[,] array2D = new int[rows, cols];

    if (numMin < numMax)
    {
        // Заполняем массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = new Random().Next(numMin, numMax + 1);
            }
        }
    }

    return array2D;
}


// Метод, печатает одномерный массив
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Метод, принимает массив, возвращает сумму элементов с одинаковыми индексами.
int SumEqualIndexElements(int[,] arr)

{
    int length = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        sum += arr[i, i];
    }

    return sum;
}


int numMin = 10;
int numMax = 99;
int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");

int[,] array2D = Fill2DArray(rows, cols, numMin, numMax);

Console.WriteLine($"Случайный массив {rows}x{cols}:");
Print2DArray(array2D);

Console.WriteLine($"Сумма элементов по главной диагонали: {SumEqualIndexElements(array2D)}");
