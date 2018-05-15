using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Func委托
{
    class Program
    {

        internal static int Test1() {
            return 22;
        }


        private static int Test3(int i1,int i2) {

            return i1 + i2;
        }

        static void Main(string[] args)
        {

            Func<int> a=Test1;//如果Func中的泛型类型指定的只有一个参数，那么就表明指向的 委托方法的返回值类型

            Console.WriteLine(a());
            //Func后面可以跟很多类型，最后一个类型是返回值类型（必须有，Action则必没有返回值）
            //参数类型必须要跟指向的方法的参数类型按照顺序对应。
            Func<String,int> b = Test2;
            Console.WriteLine(b("haha"));
            Func<int, int, int> c = Test3;
            Console.WriteLine(c(2,4));

            Console.ReadKey();

        }

        private static int Test2(string arg)
        {
            return arg.GetHashCode();
        }
    }
}
