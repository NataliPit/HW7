/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
0, 0 -> 1 */


int random(int min, int max)
{
    Random rnd = new Random();
    int numbers = rnd.Next(min, max);
    return numbers;
}

int[,] FillArrayRandomNumbers(int lines, int columns)
{
    int[,] Array = new int[lines, columns];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-10, 10);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " \t");
        }
        Console.Write("");
        Console.WriteLine("");
    }
}

int[,] numbers = new int[10, 10];
bool VAlidating(int n, int m, int[,] array)
{
    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    {
        return false;
    }
    return true;
}

void PrintUserNumber(int n, int m, int[,] Array)
{
    if (VAlidating(n, m, Array))
    {
        Console.WriteLine($"В заданной ячейке число {Array[n, m]}");
        return;
    }
    Console.WriteLine("Такого числа нет!");
}

Console.Write("Введите строку: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] Array = FillArrayRandomNumbers(random(2, 10), random(2, 10));


Console.WriteLine();
PrintArray(Array);
Console.WriteLine();
PrintUserNumber(n, m, Array);


