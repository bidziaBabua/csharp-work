using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exrc7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of elements" +
                " which sum must be calculated");
            int K = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            // Filling the array
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int maxSum = int.MinValue;
            int startIndex = 0;

            for (int i = 0; i < arr.Length-K+1; i++)
            {
                sum = 0;
                for (int j = 0; j < K; j++)
                {
                    sum += arr[i + j];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    startIndex = i;
                }
            }

            Console.WriteLine();
            for (int i = startIndex; i < K+startIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
