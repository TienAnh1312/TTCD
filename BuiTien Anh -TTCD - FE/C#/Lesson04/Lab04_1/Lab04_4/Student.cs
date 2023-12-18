using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_4
{
    internal class Student : IPerson
    {
        // khai báo thuộc tinh
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong " + obj);
        }

        public void Display(object obj)
        {
            Student st = (Student)obj;
            Console.WriteLine("Id: " + st.Id);
            Console.WriteLine("Name: " + st.Name);
            Console.WriteLine("Age: " + st.Age);
        }

        public void Insert(object obj)
        {
            Console.WriteLine("Da luu doi tuong " + obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhap doi tuong " + obj);
        }
    }
}
