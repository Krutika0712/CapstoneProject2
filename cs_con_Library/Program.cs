using System;

namespace cs_con_Library
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Details D = new Details("LIBRARY *");
            int m = -1;
            while (m != 0)
            {
                int a = -1;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\t* WELCOME TO  {0}\n", D.Libraryname);
                Console.WriteLine("\t1.|    Librarian   |");
                Console.WriteLine("\t2.|    Borrower    |");
                Console.WriteLine("\t0.|    Exit        |");
                Console.WriteLine("------------------------------------------");
                Console.Write("\tEnter your choice : ");
              
                m = int.Parse(Console.ReadLine());

                switch (m)
                {
                    case 0:
                        Console.WriteLine(" \n ----****--- THANK YOU ---****----");
                        break;
                    case 1:
                        while (a != 0)
                        {
                            Console.WriteLine("------------------------------------------\n");
                            Console.WriteLine("\t0.|      Return to Home         |");
                            Console.WriteLine("\t1.|      Add a Books            |");
                            Console.WriteLine("\t2.|      Display All Books      |");
                            Console.WriteLine("\t3.|      Remove the book        |");
                            Console.WriteLine("\t4.|      Search the book        |");
                            Console.WriteLine("\t5.|      Sorting the Books      |\n");
                            Console.WriteLine("------------------------------------------");
                            Console.Write("\tEnter your choice : ");
                            a = int.Parse(Console.ReadLine());

                            switch (a)
                            {
                                case 0:
                                    Console.WriteLine("\t------ Return to Home -----");
                                    break;
                                case 1:
                                    Console.WriteLine("\t------- Add a books ------");
                                    D.AddBook();
                                    break;
                                case 2:
                                    Console.WriteLine("\t----- Display the books -----");
                                    D.DisplayAllBook();
                                    break;
                                case 3:
                                    Console.WriteLine("\t----- Remove Book ------");
                                    D.RemoveBook();
                                    break;
                                case 4:
                                    Console.WriteLine("\t----- Search Book ------");
                                    D.Searchbook();
                                    break;
                                case 5:
                                    Console.WriteLine("\t----- Sorting Book ------");
                                    D.Sorting();
                                    break;

                            }
                        }

                        break;
                    case 2:
                        int i = -1;
                        while (i != 0)
                        {
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("\t0.|       Return to Home      |");
                            Console.WriteLine("\t1.|       Issue the book      |");
                            Console.WriteLine("\t2.|       Return the book     |\n");
                            Console.WriteLine("------------------------------------------");
                            Console.Write("\tEnter your choice : ");
                            i = int.Parse(Console.ReadLine());
                            switch (i)
                            {
                                case 0:
                                    Console.WriteLine("\t----- Return to Home -----");
                                    break;
                                case 1:
                                    Console.WriteLine("\t----- Borrow Book ------");
                                    D.BorrowBook();
                                    break;
                                case 2:
                                    Console.WriteLine("\t----- Return Book -----");
                                    D.ReturnBook();
                                    break;
                            }
                        }
                        break;

                }
            }
        }


    }
}

    

 