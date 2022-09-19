// Напишите программу, которая будет создавать
//копию заданного одномерного массива с помощью
//поэлементного копирования.


int length = ReadData("Задайте длину массива: ");
int minValue = ReadData("Задайте минимальное значение: ");
int maxValue = ReadData("Задайте максимальное значение: ");

int[] array = GenArr(length, minValue, maxValue);
Print1DArray(array);
PrintResult("Копия массива");
Print1DArray(MakeArrayCopy(array));


// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] GenArr(int arrLen, int minValue, int maxValue)
{
    int[] arr = new int[arrLen];
    Random rnd = new Random();

    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.Next(10, 100);
    }
    return arr;
}
// Вывод результата в консоль
void PrintResult(string data)
{
    Console.WriteLine(data);
}

// Вывод массива в консоль
void Print1DArray(int[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
}
//Создание копии массива.
int[] MakeArrayCopy(int[] arr)
{
    int[] rev = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        rev[i] = arr[i];
    }
    return rev;
}

