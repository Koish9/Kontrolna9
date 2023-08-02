// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();

        string[] array = input.Split(',');

        string[] result = FilterArray(array);

        Console.WriteLine("Результат:");
        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }
     static string[] FilterArray(string[] array)
    {
        int count = 0;

        // Подсчитываем количество строк, удовлетворяющих условию
        foreach (string item in array)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }
