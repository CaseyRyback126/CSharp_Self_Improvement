// 

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

int RecPow(int A, int B)
{
    if (B==1) return A;
    return A * RecPow(A, B - 1);
}

int A = ReadData("Введите число: ");
int B = ReadData("Введите степень: ");

PrintResult(RecPow(A,B).ToString());

