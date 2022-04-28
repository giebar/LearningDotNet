using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] planets = { "Mercury", "Mars", "Jupiter", "Saturn", "Neptune" };
            foreach (string planet in planets)
                Console.Write(planet + "\n");
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Array.Reverse(numbers);
            foreach (int number in numbers)
                Console.Write(number + " ");
        }
    }
}
