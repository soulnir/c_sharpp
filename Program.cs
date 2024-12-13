using System;
using Task;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_1 task1 = new Task_1();
            task1.Execute();

            Task_2 task2 = new Task_2();
            task2.Execute();

            Task_3 task3 = new Task_3();
            task3.Execute();

            Task_4 task4 = new Task_4();
            task4.Execute();
        }
    }
}
