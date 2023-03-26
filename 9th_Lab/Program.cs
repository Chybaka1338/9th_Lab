using System;

namespace _9th_Lab
{
    public class Program
    {
        static string[] task1_DB = new string[] {
            @"C:\Users\kakaw\source\repos\9th_Lab\9th_Lab\Task1DB\Group1.txt",
            @"C:\Users\kakaw\source\repos\9th_Lab\9th_Lab\Task1DB\Group2.txt",
            @"C:\Users\kakaw\source\repos\9th_Lab\9th_Lab\Task1DB\Group3.txt",
        };

        static string[] task4_DB = new string[]
        {
            @"C:\Users\kakaw\source\repos\9th_Lab\9th_Lab\Task4DB\Group1.txt",
            @"C:\Users\kakaw\source\repos\9th_Lab\9th_Lab\Task4DB\Group2.txt",
        };

        static void Main()
        {
            Task1.Run(task1_DB);
            Task4.Run(task4_DB);
            Console.ReadKey();
        }
    }
}
