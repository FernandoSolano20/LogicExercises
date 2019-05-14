using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listNum1 = { 1, 2, 4 };
            int[] listNum2 = { 1, 3, 4 };
            int[] listResult = new int[listNum1.Length + listNum2.Length];
            Number num = new Number();
            num.MergeList(listNum1, listNum2, listResult);
            num.WriteListResult(listResult);
        }
    }
}
