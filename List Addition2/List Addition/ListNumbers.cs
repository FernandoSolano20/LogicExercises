using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Addition
{
    public class ListNumbers
    {
        public int SubtractionNumber(Numbers listOfNumbers, int index)
        {
            if (index != listOfNumbers.listNum1.Count - 1 && listOfNumbers.listNum1?[index] + listOfNumbers.listNum2?[index] >= 10)
            {
                listOfNumbers.addOne = true;
                return 10;
            }
            else
            {
                listOfNumbers.addOne = false;
                return 0;
            }
        }
        public int AddOneToNumber(bool addOne)
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
    }
}
