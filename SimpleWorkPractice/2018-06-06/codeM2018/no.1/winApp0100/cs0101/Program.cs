using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs0101
{

    class Things //: IComparer<Things>
    {
        public int price;
        public int isAccount;

        public Things()
        {
            this.price = 0;
            this.isAccount = 0;
        }
        public Things(int price, int isAccount)
        {
            this.price = price;
            this.isAccount = isAccount;
        }
        //public int Compare(Things x, Things y)
        //{
        //    return x.price.CompareTo(y.price);
        //}

    }

    class Program
    {
        static void Main(string[] args)
        {


       
        String num = Console.ReadLine();
        char[] separator = { ' ' };

        String[] count = num.Trim().Split(separator);
        double discountSum = 0;
        int sum = 0;
        int itemCount = Int32.Parse(count[0]);
        int sale = Int32.Parse(count[1]);
        int a = 0, b = 0;
        int n = 0, m = 0;
        Things[] s = null;
        while (itemCount-- > 0) {

            count = Console.ReadLine().Trim().Split(separator);
            a = Int32.Parse(count[0]);
            b = Int32.Parse(count[1]);
            if (b == 1)
                discountSum += (double) a * 0.8;
            else
                discountSum += a;
            sum += a;
            n++;
        }
        s = new Things[sale];
        while (sale-- > 0) {

            count = Console.ReadLine().Trim().Split(separator);
            s[m] = new Things(Int32.Parse(count[0]), Int32.Parse(count[1]));
            m++;
        }

        int[] prices = new int[s.Length];
        int[] isAccounts = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            prices[i] = s[i].price;
            isAccounts[i] = s[i].isAccount;

            
        }
        Array.Sort(prices,isAccounts);


        Console.WriteLine("============");
        foreach (var item in s)
        {
            Console.WriteLine(item.price+"  "+item.isAccount);
        }
        Console.WriteLine("============");
//		for (Sale sale2 : s) {
//			System.out.println(sale2.a+" "+sale2.b);
//		}
        for (int i = s.Length - 1; i >= 0; i--) {
            Things sale2 = s[i];
            if (sale2.price <= sum) {
                sum -= sale2.isAccount;
                break;
            }
        }
            Console.WriteLine(String.Format("{0:N2}", Convert.ToDecimal(Math.Min(discountSum,sum)).ToString()));
    




        }
    }
}
