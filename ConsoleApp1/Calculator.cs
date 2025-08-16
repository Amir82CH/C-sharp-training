using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //ایجاد یک ماشین حساب ساده با چهار عمل اصلی
    public class Calculator
    {
        public int Sum()
        {
            while (true)
            {
                Console.WriteLine("Please Enter your Numbers:");
                // string input = Console.ReadLine();
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
               // if (!int.TryParse(input, out int n) || n <= 0)
               // {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"enter your {i} number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        sum += number;
                    }
                    Console.WriteLine($"Sum is: {sum}");
                    return sum;
               // }
                //else
                //{
                //    Console.WriteLine("Please enter valid number");
                //}
            }
        }
        public float Multiple()
        {
            Console.WriteLine("Please Enter your Numbers:");
            int m = Convert.ToInt32(Console.ReadLine());
            int multiple = 0;

            for (float i = 0; i < m; i++)
            {
                Console.WriteLine($"enter your {i} number");
                int number = Convert.ToInt32(Console.ReadLine());
                multiple *= number;
            }
            Console.WriteLine($"Multiple is: {multiple}");
            Console.Clear();
            return multiple;
        }

        public float Average()
        {
            Console.WriteLine("Please enter your numbers");
            float x = float.Parse(Console.ReadLine());
            float sum = 0;
            float avg = 0;

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Enter your {i} number");
                float avgNumber = Convert.ToSingle(Console.ReadLine());
                sum += avgNumber;
                avg = sum / avgNumber;
            }
            Console.WriteLine($"Average is: {avg}");
            return avg;
        }
    }
}
