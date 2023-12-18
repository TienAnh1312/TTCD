using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_4
{
    internal class Staff : IPerson
    {
        //thực thi các phương thức của dối tượng    

        public void Delete(object obj)
        {
             Console.WriteLine("Da xoa doi tuong " + obj);
        }

        public void Display(object obj)
        {
            Console.WriteLine("Thong tin doi tuong " + obj);
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
