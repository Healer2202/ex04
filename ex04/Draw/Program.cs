﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            draw1(number, 'o');
            Console.WriteLine();
            draw2(number, 'u');
            Console.WriteLine();
            draw3(number, 'v');
            Console.WriteLine();
            draw4(number, 'x');
            Console.WriteLine();
            draw5(number, '+');
        }
        public static void line(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(c);
            }
        }
        public static void square(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < number; j++)
                {
                    Console.Write(c);
                }
            }
        }
        public static void Hori(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(c);
            }
        }
        public static void draw1(int number, char c)
        {
            int space;
            //line1
            Hori(number, c); Console.WriteLine();
            //line i
            if (number % 2 == 0)
            {
                space = number / 2;
            }
            else
            {
                space = number / 2 + 1;
            }
            for (int i = 0; i < number - 2; i++)
            {
                Hori(1, c); Hori(space, ' '); Hori(1, c); Console.WriteLine();
            }
            //last line;
            Hori(number, c); Console.WriteLine();
        }
        public static void draw2(int number, char c)
        {
            //i-line
            int space;
            if (number % 2 == 0)
            {
                space = number / 2;
            }
            else
            {
                space = number / 2 + 1;
            }
            for (int i = 0; i < number - 1; i++)
            {
                Hori(1, c); Hori(space, ' '); Hori(1, c); Console.WriteLine();
            }
            //last-line
            Hori(number, c); Console.WriteLine();
        }
        public static void draw3(int number, char c)
        {
            //draw W
            //1-line
            int space1 = number + 1;
            Hori(1, c); Hori(space1, ' '); Hori(1, c); Hori(space1, ' '); Hori(1, c); Console.WriteLine();
            //i-line
            int space2 = number + 1;
            int space3 = 1;
            for (int i = 1; i <= number / 2; i++)
            {
                space2 = space2 - 2;
                Hori(i, ' '); Hori(1, c); Hori(space2, ' '); Hori(1, c); Hori(space3, ' ');
                Hori(1, c); Hori(space2, ' '); Hori(1, c); Console.WriteLine();
                space3 = space3 + 2;
            }
            //last-line
            Hori(number - 1, ' '); Hori(1, c); Hori(number + 1, ' '); Hori(1, c);

        }
        public static void draw4(int number, char c)
        {
            int topspace2 = number - 1;
            int topspace1 = 0;
            //draw X
            //top mid line
            for (int i = 0; i < number / 2; i++)
            {

                Hori(topspace1, ' '); Hori(1, c); Hori(topspace2, ' '); Hori(1, c); Console.WriteLine();
                topspace1 = topspace1 + 1;
                topspace2 = topspace2 - 2;
            }

            //mid-line
            Hori(number / 2, ' '); Hori(1, c); Console.WriteLine();
            //bot mid line
            int botspace1 = number / 2 - 1;
            int botspace2 = 1;
            for (int i = 0; i < number / 2; i++)
            {

                Hori(botspace1, ' '); Hori(1, c); Hori(botspace2, ' '); Hori(1, c); Console.WriteLine();
                botspace1 = botspace1 - 2;
                botspace2 = botspace2 + 2;
            }
        }
        public static void draw5(int number, char c)
        {
            //top-mid
            for (int i = 0; i < number / 2; i++)
            {
                Hori(number / 2, ' '); Hori(1, c); Console.WriteLine();
            }
            //middle
            Hori(number, c); Console.WriteLine();
            //bot-mid
            for (int i = 0; i < number / 2; i++)
            {
                Hori(number / 2, ' '); Hori(1, c); Console.WriteLine();
            }
        }
    }
}
