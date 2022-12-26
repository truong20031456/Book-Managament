using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    internal class Film
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Time { get; set; }
        public int PersonalMax { get; set; }
        public string FilmType { get; set; }
        public string NO { get; set; }
        public Film() { }
        public void Input()
        { int k,f,d;
            Console.WriteLine("Enter film's name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter filmType:  ");
            FilmType = Console.ReadLine();
            do
            { d = 1;

                Console.WriteLine("Ticket price: 68k to 200k ");
                Price = Int32.Parse(Console.ReadLine());
                if (Price < 68000)
                {
                    Console.WriteLine(" You enter the flowest money , Please add a little ");
                    d = 0;
                }
                else if (Price > 200000)
                {
                    Console.WriteLine(" you are risk , but we are honest, please Enter again");
                    d = 0;
                }
            } while (d == 0);
            do
            {
                f = 1;
                Console.WriteLine("Enter starting time : Only open from 6h p.m to 12h p.m  : ");
                Time = Int32.Parse(Console.ReadLine());
                if (Time >12|| Time < 6)
                {
                    Console.WriteLine(" you forgot to following above information");
                    f = 0;
                }
            } while (f == 0);
            do
            {
                k = 1;
                Console.WriteLine("Enter people go with you (0-10): ");
                PersonalMax = Int32.Parse(Console.ReadLine());
                if (PersonalMax < 0 || PersonalMax > 30)
                {
                    Console.WriteLine(" You entered wrong!!, Enter again");
                    k= 0;
                }
            } while (k == 0);
            Console.WriteLine("Enter room no: ");
            NO = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Room Information (Film's name: {0},Film Type {1}, Price: {2}, Starting: {3} Pm; Max people go with you : {4}, Room no: {5})",
                Name, FilmType, Price, Time, PersonalMax, NO);
        }
    }
}

