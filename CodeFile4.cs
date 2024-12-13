using System;

namespace Task
{
    public class Task_4
    {
        public void Execute()
        {
            Console.WriteLine("\n\nTask 4");
           
            int num = 3;
            int n = 10 + num;

            int[] X = new int[n];
            Console.WriteLine("Enter " + n + " array elements:");
            for (int i = 0; i < n; i++)
            {
                X[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter M number:");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("M: " + M);
            Console.WriteLine("Array X:");

            foreach (var item in X)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nArray Y (elements of X whose modulus is greater than M):");
            
            List<int> Y = new List<int>();


            foreach (var item in X)
            {
                if (Math.Abs(item) > M)
                {
                    Y.Add(item);
                }
            }

            foreach (var item in Y)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}