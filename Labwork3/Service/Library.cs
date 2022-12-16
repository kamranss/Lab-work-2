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
            foreach (Book item in Books)
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
            foreach (Book item in BooksForGenre)
            {
                if (item.Genre == a)
                {
                    BooksForGenre.Add(item);
                }
            }
            return BooksForGenre;
        }

        public Book FindBookByNo(int no)
        {
            foreach (Book item in Books)
            {
                if (item.Id == no)
                {
                    return item;
                }
            }
            return null;
        }

        public bool IsExistBookByNo(int no)
        {
           
            foreach (Book item in Books)
            {               
                if (item.Id == no)
                {
                    return true;
                }       
            }
            return false;
          
        }

        public void RemoveAll(Predicate<Book> function)
        {
            List<Book> newbokklist = new List<Book>();
        foreach (var item in newbokklist)
            {
                if (function(item))
                {
                   newbokklist.Add(item);
                }
            }
            
        }

    }
}
