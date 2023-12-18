using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_4
{
    internal class Custom
    {
        public class InvalidInputNumber : Exception {
            public InvalidInputNumber()
               : base("Hay nhap 1 so > 0") { }
        }
       
    }
}
