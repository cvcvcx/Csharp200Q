using System;

namespace _053
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            double n = double.Parse(Console.ReadLine());

            double sum = 0;
            for(double i =1;i<= n; i++)
            {
                double fact = 1;
                for(double j = 2; j<=i; j++)
                {
                    fact *= j;
                }
                sum += fact;
                Console.WriteLine("{0,2}! = {1,10:#,#}",i,fact);
            }
            Console.WriteLine("1! + 2! + ... + {0}! = {1:n0}\n",n,sum);
        }
    }
}
