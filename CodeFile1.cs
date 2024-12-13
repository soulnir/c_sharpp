using System;

namespace Task
{
    public class Task_1
    {
        public void Execute()
        {
            Console.WriteLine("Task 1");
           
            int num = 3;

            int min = 1;
            int max = 10 + num;

            Console.WriteLine("Enter three numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers that belong to the interval [" + min + "," + max + "]:");
            if (IsInRange(a, min, max)) Console.WriteLine(a);
            if (IsInRange(b, min, max)) Console.WriteLine(b);
            if (IsInRange(c, min, max)) Console.WriteLine(c);
        }
        
        private bool IsInRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }
        
    }
}
