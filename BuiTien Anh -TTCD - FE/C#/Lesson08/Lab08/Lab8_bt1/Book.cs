using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_bt1
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price{ get; set; }
        public string Publisher { get; set; }
        public int Year{ get; set; }
        public override string ToString()
        {
            return Id + ":" + Name + ":" + Author + ":" + Price + ":" + Publisher + ":" + Year;
        }
    }
}
