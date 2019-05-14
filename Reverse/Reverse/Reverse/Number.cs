using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    public class Number
    {
        private StringBuilder result;
        public int Num { get; set; }

        public void ReverseNumber()
        {
            result = new StringBuilder();
            if (Num<0)
            {
                result.Append("-");
                Num = Num * -1;
            }
            while (Num >= 1)
            {
                result.Append(Num % 10);
                Num = Num / 10;
            }
            Console.WriteLine(result);
        }
    }
}
