using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Action委托
{
    class Program
    {

        internal static void PrintString() {

            Console.WriteLine("hello world.");
        }

        internal static void PrintInt(int i) {

            Console.WriteLine("{0}",i);
        }



        internal static void PrintString(String i)
        {

            Console.WriteLine("{0}", i);
        }

        internal static void PrintDouble(int i1,int i2) {

            Console.WriteLine(i1+i2);
        }
        /// <summary>
        /// action后面可以通过泛型来指定action指向的方法的匹配的多个参数的类型，参数的类型和顺序和后面需要传入的委托类型相对应
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

           // Action a = PrintString;//Action是系统内置的一个委托类型，它可以指向一个没有返回值，没有任何参数的方法

            Action<int> a = PrintInt;//定义了一个委托类型，这个类型可以指向一个没有返回值，有一个int参数的方法

            Action<String> b = PrintString;//在这里，系统会自动寻找互相匹配的重载方法

            
            Action<int,int> aa=PrintDouble;//action最多支持16个类型的形参

            a.Invoke(1);
            b.Invoke("aaa");
            aa.Invoke(43,11);
            Console.ReadKey();


        }
    }
}
