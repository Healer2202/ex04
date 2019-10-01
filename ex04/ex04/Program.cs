using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static bool IsOdd(int n)
        {
            if(n %2 != 0)
            {
                return true;
            }                
                return false;
    }
        public static bool IsEven(int n)
        {
             if(n %2 == 0)
            {
                return true;
            }                
                return false;
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for(int i = 2; i < n; i++)
            {
                if (n%i ==0)                
                    return false;
                 }
                    return true;
            }
        public static int Square(int number)
        {
            return number * number;
        }
        public static int Cube(int number)
        {
            return number * number * number;
        }
        public static int pow(int number, int number2)
        {
            int result = 1;
            for (int i = 0; i < number2; i++)
            {
                result = result * number;
            }
            return result;
        }
        public static int abs(int number)
        {
            //return Math.ABS(number);
            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                return number * -1;
            }
            return number;
        }
        public static int mathceil(double number3)
        {
            if (number3 % 1 != 0)
            {
                return (int)number3 + 1;
            }
            return (int)number3;
        }
        
        public static int mathFloor(double number3)
        {
            if (number3 < 0)
            {
                return (int)number3 - 1;
            }
            return (int)number3;
        }
        public static int Random(int number)
        {
            Random rd = new Random();
            return number = rd.Next(0, 100000);
        }
        public static float random2()
        {
            Random rd2 = new Random();
            return rd2.Next(0, 1);
        }
        public static long Factorial()
        {

        }
    }
    }


