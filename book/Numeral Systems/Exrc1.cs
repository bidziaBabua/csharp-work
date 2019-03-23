using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exrc1
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            string binary = "";

            while (dec > 0)
            {
                binary += dec % 2;
                dec /= 2;
            }

            Console.WriteLine(Reverse(binary));


            Console.ReadKey();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
