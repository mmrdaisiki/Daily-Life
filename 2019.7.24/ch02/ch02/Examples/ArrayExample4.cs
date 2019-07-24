using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample.Examples
{
    class ArrayExample4
    {
        public void PrintArray()
        {
            int[] a = { 23, 64, 15, 72, 36 };
            int[] b = new int[a.Length];
            Array.Copy(a, b, a.Length);
            PrintValues("原始整数数组:", a);
            Array.Reverse(a);
            PrintValues("反转后的值:\t", a);
            Array.Sort(b);
            PrintValues("升序排序后的值:", b);
            Array.Reverse(b);
            PrintValues("降序排序后的值:", b);
            string[] books = { "Java","C#", "C++", "VB,Net" };
            Console.Write("原始字符串数组:\t");
            Console.WriteLine("\t{0}",string.Join("，",books));
            Array.Sort(books);
            Console.Write("升序排序后的字符串数组:");
            Console.WriteLine("\t{0}", string.Join("，", books));
            Console.ReadKey();
        }
        private static void PrintValues(string tip, int[] array)
        {
            Console.Write("{0,-10}", tip);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\t{0}",array[i]);
            }
            Console.WriteLine();
        }
    }
}
