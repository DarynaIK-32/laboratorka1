/*Знайти найбільше та найменше значення словника, видалити їх та відсортувати словник по ключах.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            { 3, "три" },
            { 1, "один" },
            { 7, "сім" },
            { 4, "чотири" },
            { 2, "два" },
            { 0, "нуль" },
            { -5, "мінус п'ять" }
        };

        int maxKey = int.MinValue;
        int minKey = int.MaxValue;

        foreach (var key in dictionary.Keys)
        {
            if (key > maxKey)
                maxKey = key;

            if (key < minKey)
                minKey = key;
        }

        dictionary.Remove(maxKey);
        dictionary.Remove(minKey);

        var sortedDictionary = new SortedDictionary<int, string>(dictionary);
        foreach (var pair in sortedDictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
        string json = JsonConvert.SerializeObject(sortedDictionary, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("dictionary.json", json);
    }
}
