
//جمع دو عدد دلخواه و چاپ آن

//float a;
//float b;
//float sum;
//Console.WriteLine("Please enter first number");
//a  = Convert.ToSingle(Console.ReadLine());
//Console.WriteLine("Please enter first number");
//b = Convert.ToSingle(Console.ReadLine());
//sum = a + b;
//Console.WriteLine($"sum is: {sum}");
//----------------------------------------------------------------------------
using ConsoleApp1;

//ماشین حساب

Calculator calc = new Calculator();
while (true)
{
    Console.WriteLine("Please Enter your Numbers:");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int n))
    {
        calc.Sum();
        // calc.Multiple();
        // calc.Average();
        break;
    }
    else
    {
        Console.WriteLine("Please enter valid number");
    }
}


//جمع اعداد و نمایش اعداد وارد شده

//Test test = new Test();
//var (numbers, sum) = test.TotalSum();

//foreach(var item in numbers)
//{
//    Console.WriteLine($"Item Lis of numbers are: {item}");
//}

//Console.WriteLine($"Sum is: {sum}");

//الگوریتم فیبوناچی

// set validation
//تازمانی که کاربر عدد درست را وارد نکنه همینجوری از کاربر ورودی دریافت میشه و اعتبار سنجی 
//انجام میشه

//var fibo = new Fibonatchi();

//while (true)
//{
//    Console.WriteLine("Please Enter your Number to generate Fibonatch Algorithm");
//    string input = Console.ReadLine();

//    if(int.TryParse(input, out int result) || result <= 0)
//    {
//        fibo.Fibo(result);
//    }
//    else
//    {
//        Console.WriteLine("Please enter valid and Positive Number");
//    }

//}

//fiboRecursive

//int number = 10;
//int result = fibo.FiboRecursive(number);
//Console.WriteLine($"fibo Recursive is: {result}");

//{
//void outTest(out int x)
//{
//    x = 10;
//}

//void refTest(ref int x)
//{
//    x += 15;
//}

// int result;
//  outTest(out result);
//  Console.WriteLine(result);


//  int result2 = 10;
// refTest(ref result);
// Console.WriteLine(result);
//}