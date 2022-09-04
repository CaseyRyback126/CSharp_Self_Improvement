// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.)

Console.Write("Введите число: ");
string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    int variable = 1;
    while (variable < inputNumber)
    {
        if (variable % 2 == 0)
        {
            Console.Write(variable + ", ");
        }
        variable = variable + 1;
    }
    if (inputNumber % 2 == 0)
    {
        Console.WriteLine(inputNumber);
    }

}
