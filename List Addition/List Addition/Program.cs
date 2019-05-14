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
            List<int> listNums1 = new List<int>() {2,4,3};
            List<int> listNums2 = new List<int>() {5,6,4};
            List<int> listResult = new List<int>();
            ListNumbers numberOfList = new ListNumbers();

            numberOfList.SumListNumbers(listNums1, listNums2, listResult);
        }
    }
}
