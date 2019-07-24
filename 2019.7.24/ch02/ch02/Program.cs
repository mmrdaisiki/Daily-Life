using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleExamples.Examples;
using ArrayExample.Examples;


namespace ch02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("请选择");
                Console.WriteLine("0：退出");
                Console.WriteLine("1：enumExample");
                Console.WriteLine("2：ArrayExample1");
                Console.WriteLine("3：ArrayExample2");
                Console.WriteLine("4：ArrayExample3");
                Console.WriteLine("5：ArrayExample4");
                var key = Console.ReadKey(true);  //表示输入不显示的字符
                Console.WriteLine("{0}{1}{0}",new string ('_',6),key.KeyChar);
                switch(key.KeyChar)
                {
                    case '0':return;
                    case '1':enumExample p = new enumExample(); break;
                    case '2':ArrayExample1 ae1 = new ArrayExample1();
                        ae1.PrintArray();
                        break;
                    case '3':ArrayExample2 ae2 = new ArrayExample2();
                        ae2.PrintArray();
                        break;
                    case '4':
                        ArrayExample3 ae3 = new ArrayExample3();
                        ae3.PrintArray();
                        break;
                    case '5':
                        ArrayExample4 ae4 = new ArrayExample4();
                        ae4.PrintArray();
                        break;
                }
            }
        }
    }
}
