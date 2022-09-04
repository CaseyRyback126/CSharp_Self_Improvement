// # 6 Напишите программу, которая на вход принимает число и выдаёт, 
//  является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    int outResult = inputNumber % 2;
    if (outResult == 0)
    {
       Console.WriteLine("Четное") ;
    }
    else
    {
        Console.WriteLine("Нечетное");
    }
}

