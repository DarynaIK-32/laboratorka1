/*Знайти кількість додатних і суму непарних елементів списку. (1) (3)*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 8, 0, -5, -7, 3 };

        int positiveCount = numbers.Count(n => n > 0);
        int oddSum = numbers.Where(n => n % 2 != 0).Sum();

        Console.WriteLine($"Кількість додатних чисел: {positiveCount}");
        Console.WriteLine($"Сума непарних чисел: {oddSum}");
    }
}