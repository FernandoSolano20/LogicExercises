using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Addition
{
    public class Numbers
    {
        public Numbers()
        {
            listNum1= new List<int>();
            listNum2 = new List<int>();
            listResult = new List<int>();
        }
        internal List<int> listNum1;
        internal List<int> listNum2;
        internal List<int> listResult;
        internal bool addOne = false;
        internal int sum = 0;

        public void AddNumbersLis1(int num)
        {
            listNum1.Add(num);
        }

        public void AddNumbersLis2(int num)
        {
            listNum2.Add(num);
        }

        private void WriteListResult()
        {
            foreach (int num in listResult)
            {
                Console.WriteLine(num);
            }
        }
        public void SumListNumbers(Numbers listNumbers)
        {
            ListNumbers listOfNumbers = new ListNumbers();
            int result = 0;
            for (int index = 0; index < listNum1.Count; index++)
            {
                result = listNum1[index] + listNum2[index] - listOfNumbers.SubtractionNumber(listNumbers, index) + sum;
                listResult.Add(result);
                sum = listOfNumbers.AddOneToNumber(addOne);
            }
            WriteListResult();
        }
    }
}
