﻿// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

System.Random numberGenerator = new System.Random();

int number = numberGenerator.Next(100, 1000);

Console.WriteLine(number);

int firstDigit = number / 100;
int thirdDigit = number % 10;

Console.WriteLine(firstDigit * 10 + thirdDigit);

void MyVariant()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    char[] charArray = number.ToString().ToCharArray();

    Console.WriteLine("" + charArray[0] + charArray[2]);
}

MyVariant();