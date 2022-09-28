// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// Метод вывода данных.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Метод вывода чисел от M до N.
string RecMN(int numM, int numN)
{
    //Точка остановки
    if (numM >= numN) return numN.ToString();
    string outLine = numM + " " + RecMN(numM + 1, numN);
    return outLine;
}

//Метод сложения чисел от M до N.
int RecSumMN(int numM, int numN)
{
    //Точка остановки
    if (numM >= numN) return numN;
    int outLine = numM + RecSumMN(numM + 1, numN);
    return outLine;
}

int M = ReadData("Введите число М: ");
int N = ReadData("Введите число N: ");
PrintResult((M < N) ? RecMN(M, N) : RecMN(N, M));
PrintResult((M < N) ? "Сумма чисел от М до N равна: " + RecSumMN(M, N) 
: "Сумма чисел от М до N равна: " + RecSumMN(N, M));