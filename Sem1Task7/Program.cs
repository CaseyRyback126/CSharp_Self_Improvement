//=======================================================================
// # 7 Напишите программу, которая на вход принимает трехзначное число 
// и на выходе показывает последнюю цифру этого числа.
//=======================================================================


Console.Write("Введите число: ");
string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    if (inputNumber > 99 && inputNumber < 1000)
    {
        int lastDigit = inputNumber % 10;
        Console.Write(lastDigit);
    }
    
}


