using System;
using MediumOfTwoSortedArrays;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
            Console.WriteLine("Result : {0}", result);
            Console.ReadKey();
        }
    }
}
