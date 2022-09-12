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

void PrintResult(string line)

{
    Console.WriteLine(line);
}

int numberA = ReadData("Введите число: ");
int res = VariantSumSimple(numberA);
PrintResult("Сумма чисел от 1 до введенного числа равна: " +res);


