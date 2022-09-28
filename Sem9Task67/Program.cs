//

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int SumDigit(int num)
{
    if (num / 10 == 0)
        return num;
    return SumDigit(num / 10) + num % 10;
}

int number = ReadData("Ведите число: ");
int sum = SumDigit(number);
PrintResult("Сумма цифр в числе:" + sum);
