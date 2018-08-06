using System;

namespace Week18
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


        static void Main()
        {
            for (int i = 0; i < 47; i++)
            {
                Console.WriteLine("Fibonacci");
                Console.WriteLine(Fibonacci(i));
            }


            bool isPrime = true;
            for (int i = 2; i < 100; i++)
            {
                for(int j = 2; j < 100; j++)
                {
                    isPrime = false;
                    break;
                }

                if (isPrime)
                {
                    Console.Write("\n" + Fibonacci(i))
            }
            }
           

            Console.Read();
        }
    }
}
