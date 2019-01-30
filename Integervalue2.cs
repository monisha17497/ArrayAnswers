using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayquestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(integervalue2(3));
        }
         public static bool integervalue2(int n)
        {
            int[] a = new int[] { 2, 4, 6, 8, 10 };
            bool flag = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    return flag;
                }
            }
            return false;
        }
    }
}