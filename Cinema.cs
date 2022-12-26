using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    internal class Cinema
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string No { get; set; }
        public List<Film> filmList = new List<Film>();
        public Cinema()
        {
        }

        public void Input()
        {
            Console.WriteLine("Enter ID Cinema: ");
            No = Console.ReadLine();
            Console.WriteLine("Enter Cinema's name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            Address = Console.ReadLine();
            //
            Console.WriteLine("How many film you want to add ");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Film film = new Film();
              film.Input();
                filmList.Add(film);
            }
        }

        public void Display()
        {
            Console.WriteLine("Cinema (Name of Cinema: {0}, Address: {1})", Name, Address);
            for (int i = 0; i < filmList.Count; i++)
            {
                filmList[i].Display();
            }
        }
        public void DisplayBase()
        {
            Console.WriteLine("Cinema (Name of Cinema: {0}, Address: {1})", Name, Address);
        }
    }
}
