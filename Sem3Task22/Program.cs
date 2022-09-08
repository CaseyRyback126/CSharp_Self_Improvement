// Напишите программу, которая принимает на вход
//число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
//Метод подсчета любой степени чисел от 1 до N
string LineNums(int numberN, int pow)
{
    int i = 1;

    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow(numberN, pow);
    return outLine;
}

//string LineSqr(int numberN)
// {
//     int i = 1;

//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i * i + "\t";
//         ++i;
//     }
//     outLine = outLine + numberN * numberN;
//     return outLine;
// }

void PrintResult(string line)
{
    Console.WriteLine(line);
}


int num = ReadData("Введите число N: ");

PrintResult(LineNums(num, 1));
PrintResult(LineNums(num, 2));

