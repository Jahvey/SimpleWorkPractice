using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs0100
{
    class Program
    {
        static void Main(string[] args)
        {
            string result=CodeM01();
            Console.WriteLine(result);
            Console.ReadKey();



        }


        private static string CodeM01()
        {
            string str = Console.ReadLine();
            string strTemp;
            char[] separator = { ' ' };
            int m, n;
            double minCost = double.MaxValue;
            double favorable = 0.0;
            double unfavorable = 0.0;
            double totalCost = 0;

            n = Int32.Parse(str.Split(separator)[0]);
            m = Int32.Parse(str.Split(separator)[1]);

            int[,] buy = new int[10, 2];
            int[,] discount = new int[10, 2];
            for (int i = 0; i < n; i++)
            {
                strTemp = Console.ReadLine();
                buy[i, 0] = Int32.Parse(strTemp.Split(separator)[0]);
                buy[i, 1] = Int32.Parse(strTemp.Split(separator)[1]);
            }

            for (int i = 0; i < m; i++)
            {
                strTemp = Console.ReadLine();
                discount[i, 0] = Int32.Parse(strTemp.Split(separator)[0]);
                discount[i, 1] = Int32.Parse(strTemp.Split(separator)[1]);

            }



            for (int i = 0; i < n; i++)
            {
                totalCost += buy[i, 0];
                if (buy[i, 1] == 1)
                    favorable += buy[i, 0];
                else if (buy[i, 1] == 0)
                    unfavorable += buy[i, 0];
            }
            double temp = unfavorable + favorable * 0.8;
            if (temp < minCost)
                minCost = temp;

            for (int i = 0; i < m; i++)
            {
                if (totalCost >= discount[i, 0])
                {
                    temp = totalCost - discount[i, 1];
                    if (temp < minCost)
                    {
                        minCost = temp;
                    }

                }


            }

            string result = String.Format("{0:N2}", Convert.ToDecimal(minCost).ToString());
            return result;
        }


	}
}
