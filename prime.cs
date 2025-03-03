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
            if (n <= 1 || n == 4 || (n % 2) == 0)
            {
                return false;
            }
            else if (n <= 3)
            {
                return true;
            }
            else
            {
                int t = n - 1;
                int s = 0;
                while(t % 2 == 0)
                {
                    t = t / 2;
                    s = s + 1;
                }
                
                Random rand_value = new Random();
                for (int i = 0; i < k; i++)
                {
                    int x = rand_value.Next(2, n-2);
                    if (gcd(x, n) != 1)
                    {
                        return false;
                    }
                    else
                    {
                        int y = (int)Math.Pow(x, t) % n;
                        if(y == 1 || y == n - 1)
                        {
                            continue;
                        }
                        
                        for (int j = 0; j < s - 1; j++)
                        {
                            y = (int)Math.Pow(y, 2) % n;
                            if (y == n - 1)
                            {
                                break;
                            }
                            else if (y == 1)
                            {
                                return false;
                            }
                        }

                        if (y != n - 1)
                        {    
                            return false;
                        }    
                        
                    }
                }
                return true;
                
            }
        }
        static int gcd(int a, int b)
        {
            while(b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }
            return a;
        }
    }
}
