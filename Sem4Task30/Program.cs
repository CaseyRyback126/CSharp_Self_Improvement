// Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

int[] GenArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random rnd = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

// int[] GenArray(int num)
// {
//     arr = 0;
//     arr.Length = 0;
//     Random rnd = new Random();
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0, 2);
//     }
//     return arr;
// }

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}



//void PrintResult(string line)

// {
//     Console.WriteLine(line);
// }


int[] GenArr = GenArray(ReadData("Введите длину массива: "));
PrintArr(GenArr);