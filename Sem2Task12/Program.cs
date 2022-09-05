//-----------------------------------------------------------------------------------------------------------
//                                      Задача 12
//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.
//-----------------------------------------------------------------------------------------------------------

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;
Variant1();

void Variant1()

{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    if (inputLineA != null && inputLineB != null)

    {
        inputNumberA = int.Parse(inputLineA);
        inputNumberB = int.Parse(inputLineB);
        result = (inputNumberB % inputNumberA == 0);
        if (result)
        {
            Console.WriteLine("Второе число кратно первому");
        }
        else
        {
            Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
        }
    }
}


    //Получаем два числа от пользователя
    //void ReadData()
    // {

    // }
    // Определяем кратность чисел
    //void CalculateData()
    // {

    // }
    // Выводим данные вычисления
    //void PrintData()
    // {

    // }

    //void EvVariant()
    {
        string? inputLineA = Console.ReadLine();
        string? inputLineB = Console.ReadLine();

        if (inputLineA != null && inputLineB != null)
        {
            inputNumberA = (int)int.Parse(inputLineA);
            inputNumberB = (int)int.Parse(inputLineB);

            Console.WriteLine(inputNumberB % inputNumberA == 0 ? "Является кратным" : inputNumberB % inputNumberA);
        }
    }

