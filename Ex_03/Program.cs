// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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

void CreateNewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j = j + 2)
        {
            matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
    }
}
int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Запрашиваем у пользователя кол-во строк и столбцов
int m = EnterNumber("Введите количество строк: ");
int n = EnterNumber("Введите количество строк: ");
//задаем двуменрный массив
int[,] matrix = CreateRandomArray(m, n, 0, 10);
PrintArray(matrix);
CreateNewArray(matrix);
Console.WriteLine();
PrintArray(matrix);


