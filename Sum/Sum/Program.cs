using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _nums = { 1, 6, 2, 7, 3, 5 };
            int _target = 11;

            Numbers arrayNumber = new Numbers();
            for (var i = 0; i < _nums.Length; i++)
            {
                arrayNumber.GetSum(_nums, _target,i, 0);
                arrayNumber.GetSumWhile(_nums, _target, i);
            }
        } 
    }
}
