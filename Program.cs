﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.





===================Метод вывода массива===================
void PrintArray(string[] array)
{
 for (int i = 0; i < array.Length; i++)
    {
 Console.Write(array[i] + " ");
    }
 Console.WriteLine();
}