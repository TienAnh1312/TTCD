using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_2
{
   internal abstract class Student
    {
        protected string name;
        protected int year;

        protected Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        //phương thưc khởi tạo
        public void Display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Year: {0}", year);
        }
        public abstract double Average();

    }
}
