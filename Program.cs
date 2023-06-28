using System;
using System.Collections.Generic;

namespace popovzd24
{
    class Program
    {
        static void Main(string[] args)
        {


            int sum = 0;
            int i = 0;

            while (i < 3)
            {
                Random rnd = new Random();
                int a = rnd.Next(1, 24);
                int b = rnd.Next(1, 24);
                int c = rnd.Next(1, 24);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == a || x == b || x == c)
                {
                    sum++;
                }
                i++;
            }

            if(sum >= 2)
                Console.WriteLine("Вы победили!");
            else if (sum < 2)
                Console.WriteLine("Вы проиграли!");
        }
    }
}
