// Домашнее задание №7
// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] a = new double[3, 4];

// Random random = new Random();
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         a[i, j] = random.NextDouble()*10; 
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
// }

// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + "\t  ");
//         Console.WriteLine();
// }

//  Console.WriteLine("Введите координаты");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m && b>n)
//  Console.WriteLine("Такого числа нет");
//  else
//  {
//  object c = array.GetValue(a,b);
//  Console.WriteLine(c);
//  }

// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             matrix[i, j] = new Random().Next(11); 
//         }
//     }
//     return matrix;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t"); 
//         }
//         Console.WriteLine();
//     }
// }
// for (int i = 0; i < 4; i++)
// {
//     int summ = 0;
//     for (int j = 0; j < 3; j++)
//     {
//         summ = summ + resultMatrix[j, i];
//     }
//     double average = summ / 3;
//     int n = i + 1;
//     Console.WriteLine("Среднее арифметическое " + n + " столбца " + average);
// }
