using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exrc4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the arrays: ");
            int arrLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];

            Console.WriteLine("Enter the values of the array: ");
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int len = 1;
            int maxLen = int.MinValue;
            int number = 0;
            int maxNumber = 0;
            int element = arr[0];
            for (int i = 1; i < arrLength; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    len = 1;
                }
                else if (arr[i] == arr[i - 1])
                {
                    len++;
                    number = arr[i];
                }

                if (maxLen < len)
                {
                    maxLen = len;
                    maxNumber = number;
                }
            }

            for (int i = 0; i < maxLen; i++)
            {
                Console.Write(maxNumber + ", ");
            }

            Console.ReadKey();
        }
    }
}
