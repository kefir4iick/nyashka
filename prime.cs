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
            if(millerrabin(n,k))
            {
                Console.WriteLine("is prime");
            }
            else
            {
                Console.WriteLine("isn't prime");
            }
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
        
        static bool millerrabin(int n, int k)
        {
            if (n <= 1 || n == 4)
            {
                return false;
            }
            else if (n <= 3)
            {
                return true;
            }
            else
            {
                return true;
                
            }
        }
    }
}
