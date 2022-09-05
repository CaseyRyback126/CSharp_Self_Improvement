// # 6 Напишите программу, которая на вход принимает число и выдаёт, 
//  является ли число чётным (делится ли оно на два без остатка).

//считываем данные
Console.Write("Введите число: ");
string? inputline = Console.ReadLine();

//проверка на пустое значение
if (inputline != null)
{
    int inputNumber = int.Parse(inputline);// присваиваем вещественное значение
    int outResult = inputNumber % 2;// проверяем остаток от деления на 2
    if (outResult == 0)
    {
       Console.WriteLine("Четное") ;// выводим если остатка нет
    }
    else
    {
        Console.WriteLine("Нечетное");// выводим если остаток есть
    }
}

