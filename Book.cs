using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    internal class Book
    {
        public int Bookingdates { get; set; }
        public int Dateofticket { get; set; }
        public string Email { get; set; }
        public string CinemaNo { get; set; }
        public string FilmTickets { get; set; }

        public Book()
        {
        }

        public void Input(List<Clients> customerList, List<Cinema> CinemaList)
        {
            Console.WriteLine("Enter Customer Email's: ");
            Email = Console.ReadLine();
            bool isFind = false;
            for (int i = 0; i < customerList.Count; i++)
            {
                if (customerList[i].EMAIL.Equals(Email))
                {
                    isFind = true;
                    break;
                }
            }

            if (!isFind)
            {
                Console.WriteLine("Invalid Customer >> Input Customer");
                Clients customer = new Clients();
                customer.EMAIL = Email;
                customer.InputWithoutEmail();
                customerList.Add(customer);
            }
            // nhap ma ks
            DisplayCinemaMenu(CinemaList);
            Cinema cinema = null;
            while (true)
            {
                CinemaNo = Console.ReadLine();
                //check ma ks coi dung chua
                isFind = false;
                for (int i = 0; i < CinemaList.Count; i++)
                {
                    if (CinemaList[i].No.Equals(CinemaNo))
                    {
                        isFind = true;
                        cinema = CinemaList[i];
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ID's Cinema>> Enter again!: ");
                }
            }
            //nhap ma phong
            DisplayFilmMenu(cinema);
            while (true)
            {
                FilmTickets = Console.ReadLine();
                isFind = false;
                for (int i = 0; i < cinema.filmList.Count; i++)
                {
                    if (cinema.filmList[i].NO.Equals(FilmTickets))
                    {
                        isFind = true;
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Film no>> Enter again!: ");
                }
            }
            int k,f;
            do {
                f = 1;
                Console.WriteLine("Enter booking date: ");
                Bookingdates = Int32.Parse(Console.ReadLine());
                if (Bookingdates < 0|| Bookingdates> 31)
                {
                    Console.WriteLine(" You enter wrong booking date");
                    f = 0;
                }
            } while (f == 0);
            do
            {
                k = 1;
                Console.WriteLine("Enter Date of ticket: ");
                Dateofticket = Int32.Parse(Console.ReadLine());
                if (Dateofticket < 0 || Dateofticket > 31)
                {
                    Console.WriteLine(" You enter wrong Date of ticket");
                    k = 0;
                }
            } while(k == 0);
        }

        public void DisplayCinemaMenu(List<Cinema> hotelList)
        {
            for (int i = 0; i < hotelList.Count; i++)
            {
                Console.WriteLine("{0}. Name Cinema {1} - ID Cinema {2}", i + 1, hotelList[i].Name, hotelList[i].No);
            }

            Console.WriteLine("Enter ID's Cinema");
        }

        public void DisplayFilmMenu(Cinema cinema)
        {
            for (int i = 0; i < cinema.filmList.Count; i++)
            {
                Console.WriteLine("{0}. NameFilm {1} - Film no {2}", i + 1, cinema.filmList[i].Name, cinema.filmList[i].NO);
            } // mã film = film no 

            Console.WriteLine("Enter Film no: ");
        }
    }
}

