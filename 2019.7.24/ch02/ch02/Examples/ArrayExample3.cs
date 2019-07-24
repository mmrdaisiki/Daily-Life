using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample.Examples
{
    class ArrayExample3
    {
        public void PrintArray()
        {
            int[] a = { 10, 20, 4, 8 };
            string[] s = GetStrings(a);
            Console.WriteLine("初始值{0}", string.Join(",", s));
            Console.WriteLine("平均值{0}", string.Join(",", a.Average()));
            Console.WriteLine("和{0}", string.Join(",", a.Sum()));
            Console.WriteLine("最大值{0}", string.Join(",", a.Max()));
            Console.WriteLine("最小值{0}", string.Join(",", a.Min()));
            Console.ReadKey();
        }
        private string[] GetStrings(int[] a)
        {
            string[] s = new string[a.Length];
            for(int i=0;i<a.Length;i++)
            {
                s[i] = a[i].ToString();
            }
            return s;
        }
    }
}
