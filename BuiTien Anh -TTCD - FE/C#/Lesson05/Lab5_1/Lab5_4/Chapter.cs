using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    internal class Chapter
    {
        private string name;
        private string content;
        //contructor không tham số
        public Chapter() {
            name = "";
            content = "";
        }
        //Contructor có tham số
        public Chapter(string name, string content)
        {
            this.name = name;
            this.content = content;
        }
        //định nghĩa các thuộc tính
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        //ghì đè phương thức tostring
        public override string ToString()
        {
            return name + "\n" + content;
        }
    }
}
