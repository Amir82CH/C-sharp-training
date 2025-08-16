using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //جمع n عدد برحسب ورودی کاربر
    //و نمایش یک لیست از اعداد وارد شده
    public class Test
    {
        public (List<int>numbers , int sum) TotalSum()
        {
            Console.WriteLine("Please Enter your numbers:");
            int x = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            int sum = 0;

            for(int i=0;i < x;i++)
            {
                Console.WriteLine($"Enter your {i} number");
                int num = int.Parse(Console.ReadLine());
                sum += num;
                numbers.Add(num);
            }

            return (numbers, sum);
        }
    }
}
