using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Fibonatchi
    {
        //الگوریتم فیبوناچی ساده
        public void Fibo(int count)
        {
            int num1 = 0;
            int num2 = 1;
            Console.WriteLine("Fobonatchi Series:");
            if (count >= 0)
                Console.WriteLine(num1);
            if (count >= 1)
                Console.WriteLine(num2);
            for (int i = 2; i < count; i++)
            {
                int num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }
        }

        //الگوریتم فیبوناچی بازگشتی
        public int FiboRecursive(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                return FiboRecursive(n - 1) + FiboRecursive(n - 2);
            }
        }

        //الگوریتم فیبوناچی ساده با شرط اینکه 
    }
}
