// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.


//Тип double чтобы учесть ввод отрицательных чисел.
double ReadData(string line)
{
    Console.Write(line);
    //Считываем число и преобразуем из строки в double
    double click = double.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return click;
}
//Подсчет чисел больше 0.
int Count(double number)
{
    int res = 0;
    for (int i = 0; i < number; i++)
    {
        double num = ReadData("");
        if (num > 0) res++;
    }
    return res;
}
//Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

double clickNumber = ReadData("Введите количество чисел для проверки: ");
Console.WriteLine("Вводите числа через Enter");
PrintResult("Количество чисел больше 0: " + Count(clickNumber));
