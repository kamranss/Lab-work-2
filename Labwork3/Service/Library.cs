using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Labwork3
{
    internal class Library
    {
        List<Book> Books = new List<Book>();

        public List<Book> FilterbyPrice( int a, int b)
        {
            List<Book> BooksForPrice = new List<Book>();
            foreach (var item in Books)
            {
                if (item.Price > a && item.Price < b)
                {
                    BooksForPrice.Add(item);
                }
            }
            

            foreach (var item in BooksForPrice)
            {
                return BooksForPrice.Find(item);
            }
           
        }

        public List<Book> FilterbyGenre(GenreEnums a)
        {
            List<Book> BooksForGenre = new List<Book>();
            foreach (var item in BooksForGenre)
            {
                if (item.Genre == a)
                {
                    BooksForGenre.Add(item);
                }
            }
            return BooksForGenre;
        }

        public void FindBookByNo(int a)
        {
            List<Book> BooksforNo = new List<Book>();
            foreach (var item in BooksforNo)
            {
                if (item.Id == a)
                {
                    BooksforNo.Add(item);
                }
            }
        }

        public bool IsExistBookByNo(int no)
        {
            int count = 0;
            foreach (var item in Books)
            {
                
                if (item.Id == no)
                {
                    count++;
                }
       
            }
            if (count > 1)
            {
                return true;
            }
            return false;

        }

        public void RemoveAll(Predicate<Book> function)
        {
            List<Book> UselessBooks = new List<Book>(Books);

            foreach (var item in UselessBooks)
            {
                if (function(item))
                {
                    UselessBooks.Add(item);
                }
            }
        }

    }
}
