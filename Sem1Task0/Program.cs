string? inputline = Console.ReadLine();
if (inputline!= null)
{
    int inputNumber = int.Parse(inputline);

    DateTime d1 = DateTime.Now;

    int outNumber = inputNumber * inputNumber;
    DateTime d2 = DateTime.Now;
    Console.WriteLine(d1-d2);
}

