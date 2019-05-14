using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Addition
{
    public class ListNumbers
    {
        public void SumListNumbers(List<int> listNum1, List<int> listNum2, List<int> listResult)
        {
            int sum = 0;
            bool addOne = false;
            int result = 0;
            for(int index = 0; index < listNum1.Count; index++)
            {
                result = listNum1[index] + listNum2[index] - SubtractionNumber(listNum1, listNum2, index, ref addOne) + sum;
                listResult.Add(result);
                sum = AddOneToNumber(addOne);
            }
            WriteListResult(listResult);
        }
        private int SubtractionNumber(List<int> listNum1, List<int> listNum2, int index, ref bool addOne)
        {
            if (index != listNum1.Count - 1 && listNum1?[index] + listNum2?[index] >= 10)
            {
                addOne = true;
                return 10;
            }
            else
            {

                return 0;
            }
        }
        private int AddOneToNumber(bool addOne)
        {
            if (addOne == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void WriteListResult(List<int> listResult)
        {
            foreach (int num in listResult)
            {
                Console.WriteLine(num);
            }
        }
    }
}
