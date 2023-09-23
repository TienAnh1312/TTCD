using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_4
{
    internal interface IPerson
    {
        //phương thức insert
        void Insert(object obj);
        //phuoqng thức xóa
        void Delete (object obj);
        //phương thức sửa 
        void Update(object obj);
        //phương thức hiển thị
        void Display(object obj);
    }
}
