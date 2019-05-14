using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(LengthWithoutDuplicates(num));

        }
        public static int LengthWithoutDuplicates(int[] num)
        {
            int lenght = 0;
            for (var i = 0; i < num.Length; i++)
            {
                if (i == 0 || num[i] != num?[i-1])
                {
                    lenght++;
                } 
            }
            return lenght;
        }
    }
}
