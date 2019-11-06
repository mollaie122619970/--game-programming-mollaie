using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            f1(5, 4);

            sum(3, 5, 12);


            int sum1 = 0;
            for (int i = 1; i <= 100; i++)
            sum1 = sum1 + i;
            {
            Console.WriteLine(sum1);
            }


            int m=1;
            Console.WriteLine("enter your num");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {

            m = m * i;
            {
            Console.WriteLine(m);
            }
            }


            Console.WriteLine("name");
            string name = Console.ReadLine();
            for (int k = 0; k < name[k]; k++)
            {
            if (name == "a" || name == "u" || name == "o" || name == "i" || name == "o")
            {
            k++;
            }
            int num1 = k++;
            if (num1 % 2 == 0)
            {
            Console.WriteLine("girl");
            }
            else if (num1 % 2 == 1)
            {
            Console.WriteLine("boy");
            }
            }
                  


            Console.WriteLine("enter your x");
            int f = int.Parse(Console.ReadLine());
            while (f!=0)
            int count=0;
            int r=f%10;
            count++;
            f=f/10;
            {
            Console.WriteLine(count);
            }




             Console.WriteLine("enter your d");
             int d = int.Parse(Console.ReadLine());
             int h;
             int sum2=0;
             while (d!=0)
             h = d % 10;
             sum2 = sum2 * 10+h ;
             d = d / 10;
             {
             Console.WriteLine(sum2);
             }

           

              Console.WriteLine("enter your number one");
              int num2 = int.Parse(Console.ReadLine());
              Console.WriteLine("enter your operand(+,-,*,/)");
              int operand = int.Parse(Console.ReadLine());
              Console.WriteLine("enter your number two");
              int num3 = int.Parse(Console.ReadLine());
              switch(operand)
              {
              case'+':
              Console.WriteLine("num2+ num3");
              break;
              case'-':
              Console.WriteLine("num2- num3");
              case'*':
              Console.WriteLine("num2*num3");
              break;
              case'/':
              Console.WriteLine("num2/ num3");
              break;
              defult:
              Console.WriteLine("notfound");
              break;
              }

           
              }
              static void f1(int x, int y)
              {

            int mul1 = 0;
            int mul2 = 0;
            mul1 = x * x;
            mul2 = y * y;
            int sum = mul1 + mul2;
            Console.WriteLine(sum);


            int x1 = 0;
            int x2 = 1;
            int x3;
            for (int i = 0; i < 5; i++)
            {
            x3 = x1 + x2;
            x1 = x2;
            x2 = x3;
            }

            {
             Console.WriteLine(x1);
            }


            Console.WriteLine("enter your average");
            float input = float.Parse(Console.ReadLine());
            if (input >= 15)
            {
            Console.WriteLine("your average is good");
            }
            else
            {
            Console.WriteLine(" your average is bad");
            }



            Console.WriteLine("enter your salary");
            int salary = int.Parse(Console.ReadLine());
            if (salary <= 700000)
            {
            double tax = 0.01 * salary;
            Console.WriteLine(tax);
            }
            else
            {
            double tax = 0.02 * salary;
            Console.WriteLine(tax);
            }



            Console.WriteLine(" shoa  ra vared konid");
            int r = int.Parse(Console.ReadLine());
            double result = 3.14 * r * r;
            double output = 2 * 3.14 * r;
            Console.WriteLine(output);
            Console.WriteLine(result);
            }





            static void sum(int x, int y, int z)
            {
            int sum = x + y + z;
            int average1 = sum / 3;
            {
            Console.WriteLine(average1);
            }
            }
                

    }
}
