// Задача 51: Задайте двумерный массив. Найдите сумму элементов основной диагонали массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
int SumNumbersMethod(int[,] matrix) //метод суммирует числа с четным индексом
{
    int SumNumbers = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if(i == j)
           {
            SumNumbers = SumNumbers + matrix[i,j];
           } 
        }    
    }
    return SumNumbers;
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

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// получить от пользователя m & n
int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите значение n: ");
// создать и заполнить двумерный массив
int[,] matrix = CreateRandomArray(m, n, 0, 10);
// посчитать сумму чисел основной диагонали массива
int SumNumbers = SumNumbersMethod(matrix);
// вывод массив в консоль
PrintArray(matrix);
Console.WriteLine($"Сумма чисел диагонали матрицы: {SumNumbers}");