﻿// Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//выдаёт номер четверти плоскости, в которой
//находится эта точка.

// чтение данных из сонсоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

int QuaterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;
        return -1;
}


void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("Введите координату Х: ");
int y = ReadData("Введите координату Y: ");

int res = QuaterTest(x, y);

PrintResult("Точка находится в четверти №: " + res);