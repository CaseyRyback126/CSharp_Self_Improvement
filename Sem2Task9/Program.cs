// Напишите программу, которая выводит случай ное число из отрезка [10,99]
// и показывает наибольшую цифру числа.



void Variant()

{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}


void EvVariant()

{
System.Random numberGenerator = new System.Random();

int number = numberGenerator.Next(10, 100);

int firstDigit = number / 10;
int secondDigit = number % 10;

    Console.Write((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

EvVariant();
Variant();