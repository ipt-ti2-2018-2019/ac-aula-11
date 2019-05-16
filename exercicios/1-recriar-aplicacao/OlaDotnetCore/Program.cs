using System;
using System.Collections.Generic;
using System.Linq;

namespace OlaDotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int> { 1, 2, 3, 4, 5 };

            var soma = nums.Sum();

            Console.WriteLine($"{string.Join(" + ", nums)} é igual a {soma}");
        }
    }
}
