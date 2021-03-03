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
            for (int i = 0; i < students.GetLength(0); i++)
            {
                total1 += students[0, i];
                Console.WriteLine(total1);
            }
            for (int i = 0; i < students.GetLength(1); i++)
            {
                total2 += students[1, i];
                Console.WriteLine(total2);
            }
            if(total1 > total2)
            {
                Console.WriteLine($"Student name: {student1}, position: 1, Total: {total1}/300");
                Console.WriteLine($"Student name: {student2}, position: 2, Total: {total2}/300");
            }
            else
            {
                Console.WriteLine($"Student name: {student2}, position: 1, Total: {total2}/300");
                Console.WriteLine($"Student name: {student1}, position: 2, Total: {total1}/300");
            }


        }
    }
}
