// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// Например:
// m = 3, n = 4.
// -1 4 8 19
// 5 -2 33 -2
// -77 3 8 1

// Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

 ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
// // Печать двумерного массива цветом
// void Print2DArrayColored(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new System.Random().Next(0,16)];
//             Console.Write($"{matr[i, j]} ");
//             Console.ResetColor(); 
//         }
//         Console.WriteLine();
//     }
// }


// int row = ReadData("Введите количество строк");
// int column = ReadData("Введите количество столбцов");

// int[,] arr2D = Fill2DArray(row,column,10,99);
// Print2DArrayColored(arr2D);



int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
//Генерация двумерного массива.
int[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)
{
    System.Random rnd = new System.Random();
    int[,] arr2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr2D[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return arr2D;
}

// Печать двумерного массива
void Print2DArrayColored(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write($"{matr[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] array2D = Gen2DArr(row, column, 10, 99);
Print2DArrayColored(array2D);