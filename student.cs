using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Student // variables, constructor,method,property,indexer,event
    {
        // variables or data members
        private int rollno;
        private string name;
        private int phy, che, maths, total;
        private double percentage;

        //constructor
        public Student()
        {
            rollno = 1;
            name = "Test";
            phy = 0;
            che = 0;
            maths = 0;

        }
        public Student(int rollno, string name, int phy, int che, int maths)
        {
            this.rollno = rollno; // this keyword points to the data member
            this.name = name;
            this.phy = phy;
            this.che = che;
            this.maths = maths;
        }
        public void Calculation()
        {
            total = phy + che + maths;
            percentage = (double)total / 3;
        }
        public string Display()
        {
            return $"\n Roll No : {rollno} \n Name : {name} \n Total = {total} \n Percentage = {percentage} %";
        }
    }

}
