//=======================================================
// # 19 Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
//=======================================================
// Метод считывания данных пользователя
// string ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем строку
//     string inputLine = Console.ReadLine() ?? "";
//     // Возвращаем значение
//     return inputLine;
// }
// // Метод, принимает строку, выводит в консоль
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }
// // Метод, возвращающий словарь четырехзначных палиндромов
// Dictionary<int, int> FillPalindroms()
// {
//     Dictionary<int, int> palindroms = new Dictionary<int, int>();
//     // Цикл внутри цикла, заполняющих значения словаря палиндромов
//     for (int i = 1; i < 10; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//             int key = j * 10 + i;
//             int value = i * 1000 + j * 100 + j * 10 + i;
//             palindroms.Add(key, value);
//         }
//     }
//     return palindroms;
// }
// // Метод, проверяющий на палиндром
// bool CheckIfPalindrom(int inputNumber, Dictionary<int, int> palindroms)
// {
//     // Делаем из исходного пятизначного числа четырёхзначное, убирая третью цифру
//     int fourDigitNumber = (inputNumber / 1000) * 100 + inputNumber % 100;
//     // Проверка на вхождение в словарь палиндромов
//     return palindroms.ContainsValue(fourDigitNumber);
// }
// int inputNumber = 0;
// string inputLine = ReadData("Введите пятизначное число: ");
// if (int.TryParse(inputLine, out inputNumber))
// {
//     if (inputNumber > 9999 && inputNumber < 100000)
//     {
//         Dictionary<int, int> fourDigitPalindroms = FillPalindroms();
//         PrintResult(CheckIfPalindrom(inputNumber, fourDigitPalindroms) ? "Это палиндром" : "Это не палиндром");
//     }
//     else
//     {
//         PrintResult("Это не пятизначное число");
//     }
// }
// else
// {
//     PrintResult("Это не число");
// }



Console.Write("Введите число: ");
string? number = Console.ReadLine();

void NumCheck(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Число: {number} - палиндром.");
    }
    else Console.WriteLine($"Число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
    NumCheck(number);
}
else Console.WriteLine($"Введите пятизначное число");