// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.


//считываем данные
Console.Write("Введите первое число: ");
string? inputLineA = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLineB = Console.ReadLine();
//проверка на пустое значение
if (inputLineA != null && inputLineB != null)
{
    int inputNumA = int.Parse(inputLineA);
    int inputNumB = int.Parse(inputLineB);
    //сравниваем числа и выводим результат
    if (inputNumA > inputNumB)
    {
        Console.WriteLine("Первое число больше второго");

    }
    else
    {
        Console.WriteLine("Второе число больше первого");
    }

}
