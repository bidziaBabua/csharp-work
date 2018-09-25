using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exrc9
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int sum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine(maxSum);

            Console.ReadKey();
        }
    }
}
