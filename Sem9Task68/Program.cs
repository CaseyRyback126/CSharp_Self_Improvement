// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Чтение данных из консоли.
uint ReadData(string line)
{
    Console.Write(line);
    uint number = uint.Parse(Console.ReadLine() ?? "");
    return number;
}

// Метод вывода данных.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// функция Аккермана
uint AckermanFunc(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AckermanFunc(n - 1, 1);
    else
        return AckermanFunc(n - 1, AckermanFunc(n, m - 1));
}

uint m = ReadData("Введите число m: ");
uint n = ReadData("Введите число n: ");

PrintResult(AckermanFunc(m, n).ToString());