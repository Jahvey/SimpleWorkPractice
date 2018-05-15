using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0001_Event01
{
    class Program
    {

        public   delegate string Eve();
        public static event Eve eve;

        public static  string Trigger() {

            if (eve != null) return eve();
            else return "";
        }

        public static string A1() {

            return "a1";
        }


        public static string A2()
        {

            return "a2";
        }


        static void Main(string[] args)
        {
            /**
            Program event1 = new Program();
            event1.eve += event1.A1;
            Console.WriteLine(event1.Trigger());
            */

            /**
            Eve event1 = A1;
            eve = Trigger;
            eve();
            */
            Console.ReadKey();

        }
    }
}
