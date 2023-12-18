using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_bt3
{
    public class invalidMarkException : Exception
    {
        public invalidMarkException(string message)
        : base(message{ }
    }

    internal class Student
    {
        private int Id;
        private string Name;
        private float Theorymark;
        private float LabMark;

        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public string name
        {
            get { return name; }
            set { name = value; }
        }
        public float theorymark
        {
            get {
                if (Value < 0 || )
                {
                    
                }
            }
            set { theorymark = value; }
        }
        public float labmark
        {
            get { return labmark; }
            set { labmark = value; }
        }
    }
}
