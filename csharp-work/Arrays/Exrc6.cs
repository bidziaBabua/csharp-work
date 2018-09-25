using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Exrc6
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };

            int[] newArr = Lis(arr);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }

            Console.ReadKey();
        }

        static int[] Lis(int[] X)
        {
            int N = X.Length;
            int[] P = new int[N];
            int[] M = new int[N + 1];

            int L = 0;
            for (int i = 0; i <= N-1; i++)
            {
                // Binary search for the largest positive j <= L
                int lo = 1;
                int hi = L;
                while (lo <= hi)
                {
                    int mid = (int)Math.Ceiling((decimal)(lo + hi) / 2); //!!!
                    if (X[M[mid]] < X[i])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid - 1;
                    }
                }

                int newL = lo;

                P[i] = M[newL - 1];
                M[newL] = i;

                if (newL > L)
                {
                    L = newL; 
                }
            }

            int[] S = new int[L];
            int k = M[L];
            for (int i = L-1; i >= 0; i--)
            {
                S[i] = X[k];
                k = P[k];
            }

            return S;
        }
    }
}
