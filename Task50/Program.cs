// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintArray(int[,] intArray)
{
    for (int i = 0; i < intArray.GetLength(0); i++)
    {
        for (int j = 0; j < intArray.GetLength(1); j++)
        {
            Console.Write($"{intArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();
Console.Write("Введите номер строки: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int b = int.Parse(Console.ReadLine());

void checkNumb(int[,] array)
{
    if (a > array.GetLength(0) || b > array.GetLength(1))

        Console.WriteLine("Такого числа в массиве нет");
    else
        Console.WriteLine("Значение элемента = {0}", array[a - 1, b - 1]);
}
checkNumb(array);