using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle
{
    class Circle
    {
        public void logic()
        {
            try
            {
                double n = 0;
                int x, y, a, b, r;
                Console.WriteLine("Enter co ordinates of centre of the circle x and y:");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Radius of the circle: ");
                r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter any point a and b: ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                n = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));

                if (n > r)
                {
                    Console.WriteLine("Point lies outside the circle.");
                }
                else
                {
                    Console.WriteLine("Point lies inside the circle.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
