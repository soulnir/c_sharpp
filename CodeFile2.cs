using System;

namespace Task
{
    public class Task_2
    {
        public void Execute()
        {
            Console.WriteLine("\n\nTask 2");
            Console.WriteLine("\nEnter the three sides of the triangle:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (IsValidTriangle(a, b, c))
            {
                double perimeter = a + b + c;
                double plosh_trik = Math.Sqrt((perimeter / 2) * ((perimeter / 2) - a) * ((perimeter / 2) - b) * ((perimeter / 2) - c));

                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Area: " + plosh_trik);

                DetermineTriangleType(a, b, c);
            }
            
            else
            {
                Console.WriteLine("A triangle with such sides does not exist");
            }
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private void DetermineTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("An equilateral triangle");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("An isosceles triangle");
            }
            else
            {
                Console.WriteLine("The triangle is versatile");
            }
        }
    }
}
