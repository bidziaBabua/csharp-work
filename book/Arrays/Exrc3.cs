using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exrc3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the arrays: ");
            int arrLength = int.Parse(Console.ReadLine());

            char[] arr1 = new char[arrLength];
            char[] arr2 = new char[arrLength];

            Console.WriteLine("Enter the values of 1st array: ");
            for (int i = 0; i < arrLength; i++)
            {
                arr1[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the values of 2nd array: ");
            for (int i = 0; i < arrLength; i++)
            {
                arr2[i] = char.Parse(Console.ReadLine());
            }
            bool equal = true;
            for (int i = 0; i < arrLength; i++)
            {
                if (arr1[i].CompareTo(arr2[i]) > 0)
                {
                    Console.WriteLine("2nd array is FIRST");
                    equal = false;
                    break;
                }
                else if (arr1[i].CompareTo(arr2[i]) < 0)
                {
                    Console.WriteLine("1st array is FIRST");
                    equal = false;
                    break;
                }
            }

            if (equal != false)
            {
                Console.WriteLine("They are equal");
            }

            Console.ReadKey();
        }
    }
}
