using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3._2
{
    internal class Contact
    {
        //Khai báo các trường
        private int id;
        private string frirstname;
        private string lastname;
        private string address;
        private string phone;
        private string email;

        //tạo constructor không tham số
        public Contact()
        {
        }

        //tọa contructor với các tham số
        public Contact(int id, string frirstname, string lastname, string address, string phone, string email)
        {
            this.id = id;
            this.frirstname = frirstname;
            this.lastname = lastname;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }
        //tạo thuộc tính cho các trường
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Frirstname
        {
            get { return frirstname; }
            set { frirstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //định nghĩa phương thức display
        public void Display()
        {
            Console.WriteLine("Ma so: " + id);
            Console.WriteLine("Ho va ten: {0} {1}", frirstname, lastname);
            Console.WriteLine("Dia chi: " + address);
            Console.WriteLine("Dien thoai: " + phone);
            Console.WriteLine("Email: " + email);
        }
    }
}
