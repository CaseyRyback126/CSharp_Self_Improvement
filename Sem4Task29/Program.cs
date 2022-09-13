// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
//Метод генерации массива любой длины и любого диапазона
int[] GenArray(int arrLength, int startNum, int stopNum)
{
    Random rnd = new Random();
    int[] outArray = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        outArray[i] = rnd.Next(startNum, stopNum);
    }
    return outArray;
}
//Вывод данных
void PrintArr(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
int arrLength = ReadData("Введите длину массива: ");
int startNum = ReadData("Введите начальное число диапазона: ");
int stopNum = ReadData("Введите конечное число диапазона: ");
int[] GenArr = GenArray(arrLength, startNum, stopNum);
PrintArr(GenArr);