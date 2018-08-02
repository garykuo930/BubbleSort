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

            for (int i = 0; i < Sort.Length - 1; i += 1) //氣泡排列法中，需進行資料數-1回合
            {
                for (int j = 0; j < Sort.Length - 1 - i; j += 1) //氣泡排列法中，兩值相比的次數為資料數-1，而"-i"為省略已比對過的排序，將演算法最佳化
                {
                    if (Sort[j] > Sort[j + 1]) //比對相鄰兩數字的大小
                    {
                        int cache = Sort[j]; // 將較大的值暫存
                        Sort[j] = Sort[j + 1]; // 將較小的數字往前移
                        Sort[j + 1] = cache; // 將較大的數字往後移
                    }
                }
            }
            // 完工，印出陣列
            for (int i = 0; i < Sort.Length; i++)
            {
                Console.WriteLine(Sort[i]);
            }
        }
    }
}
