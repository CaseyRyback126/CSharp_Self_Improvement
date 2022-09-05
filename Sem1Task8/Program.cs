// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    int variable = 2;
    while (variable <= inputNumber - 2)
    {
        Console.Write(variable + ", ");

        variable = variable + 2;
    }

    Console.Write(variable);
}
