// Задача 46: Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// 01:08:33

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}
{

}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// получить от пользователя m & n
int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите значение m: ");
// создать и заполнить двумерный массив
int[,] matrix = CreateRandomArray(m, n, 0, 10);
// вывод массив в консоль
PrintArray(matrix);