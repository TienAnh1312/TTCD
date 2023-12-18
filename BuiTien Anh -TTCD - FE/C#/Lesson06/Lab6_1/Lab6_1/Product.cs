using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    internal class Product
    {
        //khai báo trường
        string name;
        double cost;
        int onhand;

        //Contructor
        public Product(string n, double c , int h)
        {
            name  = n;
            cost = c;
            onhand = h;
        }
        //ghì đè phương thức
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C} On hand: {2}", name, cost, onhand);

        }
    }
}
