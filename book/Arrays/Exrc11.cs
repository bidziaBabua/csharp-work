using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exrc11
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
            const int S = 11;


            int startIndex = 0;
            int endIndex = 0;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == S)
                    {
                        startIndex = i;
                        endIndex = j;
                        break;
                    }
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
