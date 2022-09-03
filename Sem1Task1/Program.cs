//=======================================================================
// # 1 Напишите программу, которая на вход принимает число и
// проверяет является ли первое число квадратом второго
//=======================================================================


Console.Write("Введите первое число: ");
string? inputlineA = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputlineB = Console.ReadLine();
if (inputlineA != null && inputlineB != null)
{
    int inputNumberA = int.Parse(inputlineA);
    int inputNumberB = int.Parse(inputlineB);

    //bool outResult = (inputNumberA * inputNumberA == inputNumberB);
    //bool outResult = (inputNumberB / inputNumberA == inputNumberA);
    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA);

 
    Console.WriteLine(outResult);
}

