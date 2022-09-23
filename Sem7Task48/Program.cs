// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// Пример:
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Заполняем массив 
int[,] Fill2DArrMN(int m, int n)
{
    int[,] arr2D = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr2D[i, j] = i + j;
        }
    }
    return arr2D;
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] matrix = Fill2DArrMN(m, n);

Print2DArray(matrix);
