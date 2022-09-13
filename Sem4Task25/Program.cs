// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

long Pow(int inputNum, int inputPow)
{
    long result = 1;
    for (int i = 0; i < inputPow; i++)
    {
        result = result * inputNum;
    }
    return result;
}

void PrintResult(string line)

{
    Console.WriteLine(line);
}

int inputNum = ReadData("Введите число: ");
int inputPow = ReadData("Введите степень: ");
long poweredNum = Pow(inputNum, inputPow);
PrintResult("Ответ: " + poweredNum);