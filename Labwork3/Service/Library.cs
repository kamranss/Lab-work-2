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
        #region Creating List inside Class and initiating it within constructor
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }
        #endregion
        #region Filter Book List and retern the books within provided price range
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
        #endregion
        #region Filter Book List and retern the books according provided Genre 
        public List<Book> FilterbyGenre(GenreEnums _genre)
        {
            List<Book> BooksForGenre = new List<Book>();
            foreach (Book item in BooksForGenre)
            {
                if (item.Genre == _genre)
                {
                    BooksForGenre.Add(item);
                }
            }
            return BooksForGenre;
        }
        #endregion
        #region Find by Book id
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
        #endregion
        #region Find out whether the mentioned book exist within the list or not
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
        #endregion
        #region Remove Book from the List
        public List<Book> RemoveAll(Predicate<Book> function)
        {
            List<Book> newbooklist = new List<Book>();
        foreach (var item in Books)
            {
                if (!function(item))
                {
                   newbooklist.Add(item);
                }
            }
            return newbooklist;
        }
        #endregion

    }
}
