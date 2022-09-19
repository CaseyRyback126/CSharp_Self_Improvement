//Не используя рекурсию, выведите первые N чисел
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
 
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

// Метод, печатает одномерный массив
void Print1DArray(int[] arr)
{
    string arrString = "";

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + ", ";
    }

    arrString += arr[arr.Length - 1];
    Console.WriteLine(arrString);
}

int[] Fibonacci(int number)
{
    int[] fibonacciArr = new int[number];
    fibonacciArr[1] = 1;

    for (int i = 2; i < number; i++)
    {
        fibonacciArr[i] = fibonacciArr[i - 2] + fibonacciArr[i - 1];
    }

    return fibonacciArr;
}

int inputNumber = ReadData("Введите длину последовательности: ");

Console.WriteLine($"Последовательность Фибоначчи длиной {inputNumber}:");
Print1DArray(Fibonacci(inputNumber));

