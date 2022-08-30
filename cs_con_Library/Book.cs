using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Library
{
    internal class Book : System.IComparable
    {

        private static int bookIdcounter;

        static Book()
        {
            Book.bookIdcounter = 0;
        }

        public Book()
        {
            this._BookId = ++Book.bookIdcounter;
        }



        private int _BookId;



        public int BookId
        {
            get
            {
                return _BookId;
            }
        }
        public string BookName { get; set; }
        public decimal BookCount { get; set; }
        public decimal BookPrice { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }

        public decimal Cost
        {
            get
            {
                return BookPrice * BookCount;
            }
        }

        public int borrowCount { get; set; }

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                return 1;
            }
            else
            {
                Book otherbook = (Book)obj;
                return this.BookName.CompareTo(otherbook.BookName);

            }
        }
        public override string ToString()
        {
            return $"{BookId,5} {BookName,-20} {BookPrice,5} {BookCount,15} {Cost,20}";
        }
    }

}
