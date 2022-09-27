// Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.WriteLine("");
Console.WriteLine("\t Задача 60");
int[,,] array3D = new int[4, 4, 4];

if (array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2) <= 90)
{
    GetArray(array3D, CreateNumbers(array3D));
    PrintArray(array3D);
}
else
{ Console.WriteLine($"Величина массива превышает множество заданных чисел"); }


int[] CreateNumbers(int[,,] array3D)
{
    int[] numbers = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int currentNumber;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        numbers[i] = new Random().Next(10, 99);
        currentNumber = numbers[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (numbers[i] == numbers[j])
                {
                    numbers[i] = new Random().Next(10, 99);
                    j = 0;
                    currentNumber = numbers[i];
                }
                currentNumber = numbers[i];
            }
        }
    }
    return numbers;
}

int[,,] GetArray(int[,,] array3D, int[] array)
{
    int[,,] result = new int[array3D.GetLength(0), array3D.GetLength(1), array3D.GetLength(2)];
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = array[count];
                count++;
            }
        }
    }
    return result;
}


void PrintArray(int[,,] array)
{
    Console.WriteLine("");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"\t{array[i, j, k]} ({i}, {j}, {k}); ");
            }
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("");
        }
    }
    Console.WriteLine("");
}
