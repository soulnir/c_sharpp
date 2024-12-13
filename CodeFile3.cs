using System;

namespace Task
{
    public class Task_3
    {
        public void Execute()
        {
            Console.WriteLine("\n\nTask 3");
            
            int num = 3;
            int n = 10 + num;

            int[] array = new int[n];
            Console.WriteLine("Enter " + n + " array elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("X:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
                if (item < min) min = item;
                if (item > max) max = item;
            }

            Console.WriteLine("\nMin value: " + min);
            Console.WriteLine("Max value: " + max);
        }
    }
}
