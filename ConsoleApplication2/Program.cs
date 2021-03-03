using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total students");
            int numOfstudents = int.Parse(Console.ReadLine());
            int[,] students = new int[numOfstudents, 3];
            Console.WriteLine("Enter Student name");
            string student1 = Console.ReadLine();
            Console.WriteLine("English Marks out of 100");
            students[0, 0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Math Marks out of 100");
            students[0, 1] = int.Parse(Console.ReadLine());
            Console.WriteLine("computer Marks out of 100");
            students[0, 2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student name");
            string student2 = Console.ReadLine();
            Console.WriteLine("English Marks out of 100");
            students[1, 0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Math Marks out of 100");
            students[1, 1] = int.Parse(Console.ReadLine());
            Console.WriteLine("computer Marks out of 100");
            students[1, 2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student name");
            int total1 = 0;
            int total2 = 0;
            for(int i =0; i < students.GetLength(0); i++)
            {
                total1 += students[i, 0];
                Console.WriteLine(total1);
            }



        }
    }
}
