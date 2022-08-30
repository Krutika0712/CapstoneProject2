using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Library
{
    internal class Details
    {
        private ArrayList Abook;
        public string Libraryname { get; private set; }

        public Details(string name)
        {

            this.Libraryname = name;
            Abook = new ArrayList();
        }

        public void AddBook()
        {
            Book B = new Book();
          
            Console.WriteLine();
            Console.WriteLine("------- Enter the details of the Book ------\n");
            Console.Write("\tBook Name : ");
            B.BookName = Console.ReadLine();
            Console.Write("\tBook Price: ");
            B.BookPrice = int.Parse(Console.ReadLine());
            Console.Write("\tBook Count: ");
            B.BookCount = int.Parse(Console.ReadLine());

            Abook.Add(B);
        }


        public void DisplayAllBook()
        {
            Console.WriteLine();
            Console.WriteLine($"\t---- List of Books in {this.Libraryname.ToUpper()} ----\n");

            Console.WriteLine("{0,5} {1,-20} {2,5} {3,15} {4, 15}", "BookID", "BookName", "BookPrice", "BookCount", "Cost");

            foreach (Book c in Abook)
            {
                Console.WriteLine(c);
            }
        }

        public void RemoveBook()
        {
            this.DisplayAllBook();

            Console.Write("\t---- Enter the Id of the Book to Remove: ");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < Abook.Count; i++)
            {
                Book B = this.Abook[i] as Book;     
                if (B.BookId == id)
                {
                    this.Abook.Remove(B);
                    break;
                }
            }

        }



        public void Sorting()
        {
            this.DisplayAllBook();

            Console.WriteLine("\t---- After Sorting Elements:\n");

            Abook.Sort();

            foreach (Book p in Abook)
            {
                Console.WriteLine(p.ToString());
            }

        }



        public void Searchbook()
        {
            this.DisplayAllBook();

            Console.Write("\t---- Search by Book Id  : ");
            int find = int.Parse(Console.ReadLine());

            bool found = false;

            foreach (Book searchId in Abook)
            {
                if (searchId.BookId == find)
                {
                    Console.WriteLine("Book id : {0}\t" + "Book name : {1}\t" + "Book price : {2}\t" + "Book Count : {3}\t"+ " Cost : {4}",
                     searchId.BookId, searchId.BookName, searchId.BookPrice, searchId.BookCount, searchId.Cost);

                    Console.WriteLine("\tFound");
                    found = true;
                }


            }
            if (found == false)
            {
                Console.WriteLine("\tBook Not Found");
            }


        }

        public void ReturnBook()
        {
            this.DisplayAllBook();
            Book b = new Book();
            Console.WriteLine();
            Console.Write("\tUser id : ");
            b.UserId = int.Parse(Console.ReadLine());
            Console.Write("\tUser Name : ");
            b.UserName = Console.ReadLine();
            Console.Write("\n\tEnter the Id of the Book to return: ");
            int id = int.Parse(Console.ReadLine());
            bool found = false;


            for (int i = 0; i < Abook.Count; i++)
            {
                Book R = this.Abook[i] as Book;
                if (R.BookId == id)
                {
                    Console.Write("\tEnter how many count of this book you want return: ");
                    R.borrowCount = int.Parse(Console.ReadLine());
                    R.BookCount +=  R.borrowCount;

                    Console.WriteLine("Book id: {0} \t" + "Book name: {1} \t" + "Book price: {2} \t " +
                    "Book Count: {3} \t " + "Cost: {4} \t " + "User Id: {5} \t" + "User Name: {6}",
                    R.BookId, R.BookName, R.BookPrice, R.BookCount, R.Cost, b.UserId, b.UserName);
                    
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine("\tReturn book Date And time is: {0}", dateTime);
                    found = true;
                    break;
                }

            }
            if (found == false)
            {
                Console.WriteLine("\tBook Not found");
            }

        }
        public void BorrowBook()
        {
            this.DisplayAllBook();
           
            Console.Write("\n\tEnter the Id of the Book to issue: ");
            int id = int.Parse(Console.ReadLine());
            bool found = false;


            for (int i = 0; i < Abook.Count; i++)
            {
                Book I = this.Abook[i] as Book;
                if (I.BookId == id)
                {
                    Console.WriteLine("\t--- Book is Available---\n");
                    Console.ReadKey();
                    Console.Write("\tUser id : ");
                    I.UserId = int.Parse(Console.ReadLine());
                    Console.Write("\tuser Name : ");
                    I.UserName = Console.ReadLine();
                    Console.Write("\tEnter how many count of this book you want : ");
                    I.borrowCount = int.Parse(Console.ReadLine());
                    I.BookCount -= I.borrowCount;
                    
                    Console.WriteLine("Book id: {0} \t" + "Book name: {1} \t" + "Book price: {2} \t" + "Book Count: {3}\t" 
                     + "Cost: {4} \t" +"User Id: {5} \t" + "User Name: {6}",
                    I.BookId, I.BookName, I.BookPrice, I.BookCount, I.Cost, I.UserId, I.UserName);
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine("\t\nIssue book Date And time is: {0}", dateTime);
                    Console.WriteLine("\tBook Issue");
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("\tBook is not Available");
            }



        }
    }
}


