using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Sort = new int[5] { 155, 56, 10, 15, 6 };

            for (int i = 0; i < Sort.Length - 1; i += 1)
            {
                for (int j = 0; j < Sort.Length - 1 - i; j += 1)
                {
                    if (Sort[j] > Sort[j + 1])
                    {
                        int cache = Sort[j];
                        Sort[j] = Sort[j + 1];
                        Sort[j + 1] = cache;
                    }
                }
            }
            for (int i = 0; i < Sort.Length; i++)
            {
                Console.WriteLine(Sort[i]);
            }
        }
    }
}
