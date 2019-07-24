using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample.Examples
{
    class ArrayExample1
    {
        public void PrintArray()
        {
            int[,] b = new int[3, 5];
            Console.WriteLine("b的秩为{0}", b.Rank);
            Console.WriteLine("b的长度为{0}", b.Length);
            for(int i=0;i<b.GetLength(0);i++)
            {
                for(int j=0;j<b.GetLength(1);j++)
                {
                    Console.Write("b{0},{1}={2}", i, j, b[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
