namespace assignment_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Clients> customerList = new List<Clients>();
            List<Cinema> cinemaList = new List<Cinema>();
            List<Book> bookList = new List<Book>();

            int idea;
            do
            {
                ShowMenu();
                idea = Int32.Parse(Console.ReadLine());

                switch (idea)
                {
                    case 1:
                        Input(cinemaList);
                        break;
                    case 2:
                        Display(cinemaList);
                        break;
                    case 3:
                        InputBook(bookList, customerList, cinemaList);
                        break;
                    case 4:
                        SearchAvailableBook(bookList, cinemaList);
                        break;
                    case 5:
                        Search(bookList, cinemaList);
                        break;
                    case 6:
                        Console.WriteLine("Exit Program!!!");
                        break;
                    default:
                        Console.WriteLine("Input Failed!!!w");
                        break;
                }

            } while (idea != 6);
        }

        static void Search(List<Book> bookList, List<Cinema> cinemaList)
        {
            Console.WriteLine("Enter Cinema's ID: ");
            string Email  = Console.ReadLine();
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].Equals(Email))
                {
                    Cinema cinema = WatchfilmByNo(cinemaList, bookList[i].CinemaNo);
                    if (cinema != null)
                    {
                        cinema.DisplayBase();
                    }
                }
            }
        }

        static Cinema WatchfilmByNo(List<Cinema> cinemaList, string cinemaNo)
        {
            for (int i = 0; i < cinemaList.Count; i++)
            {
                if (cinemaList[i].No.Equals(cinemaNo))
                {
                    return cinemaList[i];
                }
            }

            return null;
        }

        static void SearchAvailableBook(List<Book> bookList, List<Cinema> cinemaList)
        {
            int checkIn, CheckOut;
            Console.WriteLine("Enter checkin buying ticket day:  ");
            checkIn = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter checkout buying ticket day: ");
            CheckOut = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < cinemaList.Count; i++)
            {
                cinemaList[i].DisplayBase();
                Console.WriteLine("------Available film List------");
                List<Film> films = cinemaList[i].filmList;
                for (int j = 0; j < films.Count; j++)
                {
                    if (checkAvailablefilm(bookList, cinemaList[i].No, films[j].NO, checkIn, CheckOut))
                    {
                        films[i].Display();
                    }
                }
            }
        }

        static bool checkAvailablefilm(List<Book> bookList, string cinemaNo, string filmNo, int checkIn, int checkOut)
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                Book book = bookList[i];
                if (book.CinemaNo.Equals(cinemaNo) && book.FilmTickets.Equals(filmNo) && (book.Bookingdates >= book.Bookingdates
                        && book.Bookingdates <= book.Dateofticket || (book.Dateofticket >= checkIn && book.Dateofticket <= checkOut)))
                {
                    return false;
                }
            }

            return true;
        }
        static void Input(List<Cinema> cinemaList)
        {
            Console.WriteLine("Enter the Cinema number to add: " + " 1 = CGV , 2 = ROCKEND, 3 = Kentsi ");
            int N = Int32.Parse(Console.ReadLine());
           
            if (N < 0 || N > 3)
            {
                Console.WriteLine(" you entered wrong cinema number?? , please folowing above information, Don't let me repeat it again");
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    Cinema cinema = new Cinema();
                    cinema.Input();
                    cinemaList.Add(cinema);
                }
            }
        }

        static void Display(List<Cinema> cinemaList)
        {
            for (int i = 0; i < cinemaList.Count; i++)
            {
                cinemaList[i].Display();
            }
        }

        static void InputBook(List<Book> bookList, List<Clients> customerList, List<Cinema> cinemaList)
        {
            Book book = new Book();
            book.Input(customerList, cinemaList);
            bookList.Add(book);
        }

        static void ShowMenu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Option 1: Enter Cinema Information");
            Console.WriteLine("Option 2: Display Cinema Information");
            Console.WriteLine("Option 3: Book Film");
            Console.WriteLine("Option 4: Find available Film");
            Console.WriteLine("Option 5: Find Client's Information");
            Console.WriteLine("Option 6: EXIT");
            Console.WriteLine("Choose option: ");
            Console.WriteLine("-----------------------------------");
        }
    }
    }
