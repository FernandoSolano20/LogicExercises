using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge
{
    public class Number
    {
        public void MergeList(int[] listNum1, int[] listNum2, int[] listResult)
        {
            for (var index = 0; index < listNum1.Length; index++)
            {
                listResult[index * 2] = listNum1[index];
                listResult[index * 2 + 1] = listNum2[index];
            }
        }
        
        public void WriteListResult(int[] listResult)
        {
            foreach (int num in listResult)
            {
                Console.WriteLine(num);
            }
        }
    }
}
