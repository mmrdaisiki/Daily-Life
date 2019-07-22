using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("huiche\n");
            string s = Console.ReadLine();
            string[] a = s.Split(',');
            int x = int.Parse(a[0]);
            int y = int.Parse(a[1]);
            int z = ClassLibraryExample.MyClass.Multiplication(x,y);
            Console.WriteLine("x*y={0}", z);
            Console.ReadKey();
        }
    }
}
