using System;

namespace HelloWorld
{
    class Program
    {
        static Random rand_value = new Random();
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
            return (int)Math.Log(n) * 3;
        }
        
        static bool millerrabin(int n, int k)
        {
            if (n <= 1 || (n % 2) == 0)
            {
                return false;
            }
            else if (n == 2 || n == 3)
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
                
                for (int i = 0; i < k; i++)
                {
                    int x = rand_value.Next(2, n-2);
                    if (gcd(x, n) != 1)
                    {
                        return false;
                    }
                    
                    int y = horner(x, t, n);
                    if(y == 1 || y == n - 1)
                    {
                        continue;
                    }
                    bool val = true;   
                    for (int j = 0; j < s - 1; j++)
                    {
                        y = horner(y, 2, n);
                        if (y == n - 1)
                        {
                            val = false;
                            break;
                        }
                        else if (y == 1)
                        {
                            return false;
                        }
                    }
                    if (val)
                    { 
                        return false;
                    }
                }
                return true;
                
            }
        }
        
        static int horner(int a, int b, int c)
        {
            int result = 1;
            a = a % c;

            while (b > 0)
            {
                if (b % 2 == 1)
                {
                    result = (int)((long)result * a % c);
                }

                a = (int)((long)a * a % c);
                b = b / 2;
            }

            return result;
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
