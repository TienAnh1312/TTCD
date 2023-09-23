using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_2
{
    /// <summary>
    /// Lớp sinh viên cao đẳng kế thùa từ lớp sinh viên
    /// </summary>
    internal class StudentCollege : Student
    {
        protected double score1, score2, score3;
        //contructor
        public StudentCollege(string name, int year, double Score1, double score2, double score3) : base(name, year)
        {
            this.score1 = Score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public override double Average()
        {
            return (score1 + score2 + score3) / 3;
        }
        //hiên thị thông tin
        public new void Display()
        {
            base.Display();
            Console.WriteLine("score1: {0:N}", score1);
            Console.WriteLine("score2: {0:N}", score2);
            Console.WriteLine("score3: {0:N}", score3);
        }
    }
}
