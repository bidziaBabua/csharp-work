using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exrc2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the arrays: ");
            int arrLength = int.Parse(Console.ReadLine());

            int[] arr1 = new int[arrLength];
            int[] arr2 = new int[arrLength];

            Console.WriteLine("Enter the values of 1st array: ");
            for (int i = 0; i < arrLength; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the values of 2nd array: ");
            for (int i = 0; i < arrLength; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            bool equal = true;
            for (int i = 0; i < arrLength; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    equal = false;
                    break;
                }
            }

            if (equal != false)
            {
                Console.WriteLine("YES! They are equal");
            }
            else
            {
                Console.WriteLine("NO! They aren't equal");
            }

            Console.ReadKey();
        }
    }
}
