using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    internal class Window
    {
        // khai báo các trường
        protected int top;
        protected int left;


        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: draw window at {0}, {1}", top, left);
        }
    }
       
}
