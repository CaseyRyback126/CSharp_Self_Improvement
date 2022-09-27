// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

class Spiral
{
    int[,] matrix;
    int mSize;
    int currentCount;

    static void Main(string[] args)
    {
        Spiral s = new Spiral(5);
        s.DrawSpiral();
    }

    public Spiral(int size)
    {
        this.mSize = size;
        matrix = new int[size, size];
        currentCount = 1;
    }
    //Метод заполнения по спирали.
    public void DrawSpiral()
    {
        //x,y   x, y+size-1
        //x+1, y+size-1     x+size-1, y+size-1
        //x+size-1, y+size-2    x+size-1, y
        //x+size-2, y   x+1, y
        int x = 0, y = 0, size = mSize;

        while (size >= 0)
        {
            for (int i = y; i <= y + size - 1; i++)
            {
                matrix[x, i] = currentCount++;
            }

            for (int j = x + 1; j <= x + size - 1; j++)
            {
                matrix[j, y + size - 1] = currentCount++;
            }

            for (int i = y + size - 2; i >= y; i--)
            {
                matrix[x + size - 1, i] = currentCount++;
            }

            for (int i = x + size - 2; i >= x + 1; i--)
            {
                matrix[i, y] = currentCount++;
            }

            x = x + 1;
            y = y + 1;
            size = size - 2;
        }
        PrintMatrix();
    }

    private void PrintMatrix()
    {
        for (int i = 0; i < mSize; i++)
        {
            for (int j = 0; j < mSize; j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write("   ");
            }
            Console.WriteLine();
        }
    }
}

