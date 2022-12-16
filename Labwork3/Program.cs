// See https://aka.ms/new-console-template for more information


using Labwork3;

#region books
Book book1 = new Book();
book1.Name = "Alibaba";
book1.Price = 20;
book1.AutorName = "Kamran";
book1.Genre = GenreEnums.Drama;

Book book2 = new Book();
book2.Name = "Bir qalanin sirri";
book2.Price = 30;
book2.AutorName = "Kamil";
book2.Genre = GenreEnums.Detective;

Book book4 = new Book();
book4.Name = "Sehirli xalat";
book4.Price = 23;
book4.AutorName = "Orxan";
book4.Genre = GenreEnums.Action;

Book book5 = new Book();
book5.Name = "Ismayil";
book5.Price = 12;
book5.AutorName = "Eyyub";
book5.Genre = GenreEnums.Melodram;
#endregion

#region Adding books to the list
Library library = new Library();
library.Books.Add(book1);
library.Books.Add(book2);
library.Books.Add(book4);
library.Books.Add(book5);
#endregion

#region Creating List from Book class because our method returns List 

List<Book> genrebook = library.FilterbyGenre(GenreEnums.Drama);

foreach (var item in genrebook)
{
    Console.WriteLine($"{item.Id} | {item.Name} | {item.Genre} | {item.AutorName} | {item.Price}");
}
Console.WriteLine("----------------------------------------------------------------------------");
#endregion

#region Filter according to price
List<Book> booksfilterprice = library.FilterbyPrice(15, 50);
foreach (var item in booksfilterprice)
{
    Console.WriteLine($"{item.Id} | {item.Name} | {item.Genre} | {item.AutorName} | {item.Price}");
}
Console.WriteLine("----------------------------------------------------------------------------");
#endregion

#region Find out whether books exist or not
bool bookexistornot = library.IsExistBookByNo(6);
Console.WriteLine(bookexistornot);
Console.WriteLine("----------------------------------------------------------------------------");
#endregion

#region Find book by Id
Book findbook = library.FindBookByNo(3);

Console.WriteLine($"{findbook?.Id} | {findbook?.Name} | {findbook?.Genre} | {findbook?.AutorName} | {findbook?.Price}");
Console.WriteLine("----------------------------------------------------------------------------");
#endregion

#region Remove Book from list
List<Book> newlist =  library.RemoveAll(lib => lib.Price == 20);
foreach (var item in newlist)
{
    Console.WriteLine($"{item.Id} | {item.Name} | {item.Genre} | {item.AutorName} | {item.Price}");
}
#endregion

