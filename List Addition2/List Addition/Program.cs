using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers listNum = new Numbers();

            listNum.AddNumbersLis1(2);
            listNum.AddNumbersLis1(4);
            listNum.AddNumbersLis1(3);

            listNum.AddNumbersLis2(5);
            listNum.AddNumbersLis2(6);
            listNum.AddNumbersLis2(4);

            listNum.SumListNumbers(listNum);
        }
    }
}
