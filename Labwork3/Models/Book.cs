using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork3
{
    internal class Book
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string AutorName { get; set; }
        public int Price { get; set; }

        static int id_no;

        public GenreEnums Genre { get; set; }
        public Book()
        {
            id_no = 0;
            Id = id_no;
        }
            

    }
}
