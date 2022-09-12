// Напишите программу, которая принимает на вход число А и 
// выдает сумму чисел от 1 до А


int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;

    for (int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

int VariantSumGausse(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((numA + 1) * numA) / 2;
    return sumOfNumbers;
}

void PrintResult(string line)

{
    Console.WriteLine(line);
}

int numberA = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGausse(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до введенного числа равна(простой метод): " + res1);
PrintResult("Сумма чисел от 1 до введенного числа равна(метод Гаусса): " + res2);


