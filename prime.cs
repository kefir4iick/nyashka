using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = pick(n);
        }
        
        static int pick(int n)
        {
            if (n < 100)
            {
                return 10;
            }
            else if (n < 1000)
            {
                return 20;
            }
            else
            {
                return 30;
            }
        }
    }
}
