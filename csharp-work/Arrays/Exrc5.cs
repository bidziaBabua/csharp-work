using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exrc5
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
            int element = arr[0];
            List<int> result = new List<int>();
            int[] maxResult = new int[arrLength];
            bool isNewSequence = true;
            for (int i = 1; i < arrLength; i++)
            {
                if (arr[i] <= arr[i - 1])
                {
                    len = 1;
                    result.Clear();
                    isNewSequence = true;
                }
                else if (arr[i] > arr[i - 1])
                {
                    if (isNewSequence)
                    {
                        result.Add(arr[i-1]);
                    }
                    len++;
                    result.Add(arr[i]);
                    isNewSequence = false;
                }

                if (maxLen < len)
                {
                    maxLen = len;
                    result.CopyTo(maxResult);
                }
            }

            for (int i = 0; i < maxLen; i++)
            {
                Console.Write(maxResult[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
