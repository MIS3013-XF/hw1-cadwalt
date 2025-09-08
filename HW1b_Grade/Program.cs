// HW1b Grade

// Your Name: Cadence Walton
// Did you seek help ? If yes, specify the helper or web link here: N/A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, id;
            double homework, participation, exam1, exam2, exam3, finalGrade;

            Console.Write("What is your first name?\n");
            firstName = Console.ReadLine();

            Console.Write("What is your last name?\n");
            lastName = Console.ReadLine();

            Console.Write("What is your student ID?\n");
            id = Console.ReadLine();

            Console.Write("What is your overall percentage grade for homework?\n");
            homework = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your overall percentage grade for participations?\n");
            participation = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your overall percentage grade for Exam 1?\n");
            exam1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your overall percentage grade for Exam 2?\n");
            exam2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your overall percentage grade for Exam 3?\n");
            exam3 = Convert.ToDouble(Console.ReadLine());

            finalGrade = 0.01 * ((homework * 0.2) + (participation * 0.15) + (exam1 * 0.15) + (exam2 * 0.25) + (exam3 * 0.25));
            Console.WriteLine($"{firstName} {lastName} ({id}), your final grade is {finalGrade.ToString("P2")}");

            Console.ReadKey();
        }
    }
}
