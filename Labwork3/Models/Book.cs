using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork3
{
    public class Book
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string AutorName { get; set; }
        public int Price { get; set; }

        static int id_no;

        public GenreEnums Genre { get; set; }

        #region Automatic Id 
        static Book()
        {
            id_no = 0;
        }
        public Book()
        {
            id_no++;
            Id = id_no;
        }
        #endregion


    }
}
