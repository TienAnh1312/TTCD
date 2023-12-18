using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_3
{
    internal abstract class Shape
    {
        protected float radius, length, width;
        //khai báo phương thúc trừu tượng
        public abstract float Area();//tính diện tích
        public abstract float Circumference();//tính chuvi
    }
}
