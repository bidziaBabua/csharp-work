using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exrc10
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            Array.Sort(arr);

            int count = 1;
            int maxCount = 0;
            int number = arr[1];

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                        number = arr[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            Console.WriteLine(number + " <-- " + maxCount + " times.");

            Console.ReadKey();
        }
    }
}
