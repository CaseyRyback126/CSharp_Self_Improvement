//=======================================================================
// # 5 Напишите программу, которая на вход принимает одно число (N),  
// а на выходе показывает все целые числа в промежутке от -N до N
//=======================================================================


Console.Write("Введите число: ");
string? inputlineN = Console.ReadLine();

if (inputlineN != null)
{
    int inputNumberN = int.Parse(inputlineN);
    if (inputNumberN > 0)
    {
        int startNum = (-1) * inputNumberN;
        while (startNum < inputNumberN)
        {
            Console.Write(startNum + ", ");
            startNum = startNum + 1;
        }
        Console.Write(inputNumberN);
    }
}


