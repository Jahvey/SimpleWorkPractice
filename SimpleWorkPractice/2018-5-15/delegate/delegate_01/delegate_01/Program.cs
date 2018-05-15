using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_01
{
    class Program
    {
        //委托是指向方法的应用，指向的是方法
        private delegate string     GetAString();
        //
        private delegate void PrintString();

        static void Main(string[] args)
        {

           // test01();
            //test02();
            test03();



        }

        private static void Method1() {

            Console.WriteLine("Method1");
        }


        private static void Method2()
        {

            Console.WriteLine("Method2");
        }
        private static void PrintStr(PrintString ps) {

            ps.Invoke();
        }

        /// <summary>
        /// 实例2 使用委托类型作为方法的参数
        /// </summary>
        private static void test03() {

            PrintString ps = Method1;
            PrintStr(ps);
             ps = Method2;
            PrintStr(ps);
            Console.ReadKey();

        
        }


        /// <summary>
        /// 测试委托
        /// </summary>
        private static void test02()
        {
            int x = 40;
            //a指向了x的tostring方法
            GetAString a = x.ToString;//注意，这里是将x.ToString方法的引用传递给委托
            Console.WriteLine(a.Invoke());//通过invoke方法来调用a所引用的方法
            Console.WriteLine(a());
            Console.ReadKey();
        }


        /// <summary>
        /// 测试委托
        /// </summary>
        private static void test01()
        {
            int x = 40;
            //a指向了x的tostring方法
            GetAString a = new GetAString(x.ToString);//注意，这里是将x.ToString方法的引用传递给委托
            Console.WriteLine(a.Invoke());
            Console.WriteLine(a());
            Console.ReadKey();
        }
    }
}
