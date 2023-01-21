using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating Object 

            //create object of student class
            Student stud = new Student(17, "Vidyanand", 77, 88, 87);
            stud.Calculation();
            Console.WriteLine(stud.Display());

        }
    }
}
