using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    internal class Clients
    {
        public string EMAIL { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public Clients()
        {
        }

        public void Input()
        {
            Console.WriteLine("Email: ");
            EMAIL = Console.ReadLine();
            Console.WriteLine("Full name: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Sex ( male or female): ");
            Sex = Console.ReadLine();
            Console.WriteLine("Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("age: ");
            Age = Int32.Parse(Console.ReadLine());
        }

        public void InputWithoutEmail()
        {
            Console.WriteLine(" Phone Number :");
            PhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Full name: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Sex ( male or female): ");
            Sex = Console.ReadLine();
            Console.WriteLine("Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("age: ");
            Age = Int32.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Customer's Information (Full Name: {0}, Age: {1}, Email: {2}), Gender: {3}, Address: {4},Phone Number: {5}",
                Fullname, Age, EMAIL, Sex, Address, PhoneNumber);
        }
    }

}
