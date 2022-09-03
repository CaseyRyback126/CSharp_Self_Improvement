//=======================================================================
// # 0 Напишите программу, которая на вход принимает число и
// выдает его квадрат (число умноженное на само себя).
//=======================================================================


Console.Write("Введите число: ");
string? inputline = Console.ReadLine();
if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    //int outNumber = inputNumber * inputNumber;
    int outNumber = (int)Math.Pow(inputNumber, 2);

    //DateTime d1 = DateTime.Now;
    //DateTime d2 = DateTime.Now;
    Console.WriteLine(outNumber);
}

