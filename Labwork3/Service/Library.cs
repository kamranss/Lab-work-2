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
        #region Creating List inside class old version
        //List<Book> Books = new List<Book>();
        #endregion
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }
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
            return BooksForPrice;
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

        public List<Book> FindBookByNo(int a)
        {
            List<Book> BooksforNo = new List<Book>();
            foreach (var item in BooksforNo)
            {
                if (item.Id == a)
                {
                    BooksforNo.Add(item);
                }
            }
            return BooksforNo;
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

        public List<Book> RemoveAll(Predicate<Book> function)
        {
        foreach (var item in Books)
            {
                if (function(item))
                {
                    Books.Remove(item);
                }
            }
            return Books;
        }

    }
}
