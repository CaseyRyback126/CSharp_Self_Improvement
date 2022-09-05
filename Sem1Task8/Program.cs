// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

//считываем данные
Console.Write("Введите число: ");
string? inputline = Console.ReadLine();

//проверка на пустое значение
if (inputline != null)
{
    int inputNumber = int.Parse(inputline);// присваиваем вещественное значение
    int variable = 2;//вводим переменную
    while (variable <= inputNumber - 2)//выполняется цикл, до достижения заданных условий 
    {
        Console.Write(variable + ", ");//выводятся промежуточные значения

        variable = variable + 2;//увеличиваем переменную на 2
    }

    Console.Write(variable);//выход из цикла и вывод окончательного результата
}
