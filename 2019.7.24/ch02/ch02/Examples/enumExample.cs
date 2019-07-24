using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExamples.Examples
{
    /// <summary>
    /// 
    /// </summary>
    public enum MyColor
    {
        /// <summary>
        /// 黑色
        /// </summary>
        Black,
        /// <summary>
        /// 白色
        /// </summary>
        White,
        /// <summary>
        /// 蓝色
        /// </summary>
        Blue
    };

    class enumExample
    {
        public enumExample()
        {
            MyColor myColor = MyColor.Black;
            //输出枚举值
            Console.WriteLine(myColor);
            //获取枚举类型中定义的所有符号名称
            string[] colorNames = Enum.GetNames(typeof(MyColor));
            //输出所有枚举成员
            Console.WriteLine(string.Join(",", colorNames));
            Console.ReadKey();
        }

    }
}
