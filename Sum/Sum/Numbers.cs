using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class Numbers
    {
        public void GetSum(int[] _nums, int _target,int i, int j)
        {
            if (j >= _nums.Length)
            {
                return;
            }
            else
            {
                if ((_nums[i] < _target) && (i != j) && (_nums[i] + _nums[j] == _target))
                {
                    Console.WriteLine("Recursive Methods");
                    Console.WriteLine("Index 1: " + i);
                    Console.WriteLine("Index 2: " + j);
                    return;
                }
                else
                {
                    GetSum(_nums, _target, i, j + 1);
                }
            }
        }

        public void GetSumWhile(int[] _nums, int _target, int i)
        {
            int j = 0;
            while (j < _nums.Length)
            {
                if ((_nums[i] < _target) && (i != j) && (_nums[i] + _nums[j] == _target))
                {
                    Console.WriteLine("While");
                    Console.WriteLine("Index 1: " + i);
                    Console.WriteLine("Index 2: " + j);
                    return;
                }
                else
                {
                    j++;
                }
            }
        }

    }
}
