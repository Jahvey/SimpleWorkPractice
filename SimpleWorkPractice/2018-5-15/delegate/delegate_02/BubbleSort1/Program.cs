using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort1
{
    class Program
    {
        /// <summary>
        /// BubbleSort
        /// </summary>
        /// <param name="arr"></param>
        internal static void Sort(int []arr) {

            bool swap = true;
            do
            {
                swap = false;

                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] > arr[i + 1]) { 
                    
                        int temp=arr[i];
                        arr[i]=arr[i+1];
                        arr[i + 1] = temp;
                        swap = true;//别忘记交换完一次之后修改标志位
                    }
                    
                }

            } while (swap);
        
        
        }

        static void Main(string[] args)
        {

            int[] arr = { 123,-3,22,11,56,1,2,6,8,21,23,645};
            Sort(arr);

            foreach (var item in arr)
            {
                Console.Write("{0} ",item);
            }
            Console.ReadKey();

        }
    }
}
