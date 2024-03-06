/*Переставте сусідні елементи списку. Якщо елементів непарне число, то останній елемент залишається на своєму місці.*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 0; i < numbers.Count - 1; i += 2)
        {
            int temp = numbers[i];
            numbers[i] = numbers[i + 1];
            numbers[i + 1] = temp;
        }

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

