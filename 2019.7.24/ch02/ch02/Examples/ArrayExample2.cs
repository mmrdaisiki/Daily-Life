using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample.Examples
{
    class ArrayExample2
    {
        public void PrintArray()
        {
            string[][] a = new string[3][];
            a[0] = new string[2] { "a11", "a12" };
            a[1] = new string[3] { "a21", "a22", "a23" };
            a[2] = new string[5] { "a", "b", "c", "d", "e" };
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a[i].Length;j++)
                {
                    Console.Write("a[{0}][{1}]={2}\t", i, j, a[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
