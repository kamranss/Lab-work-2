// See https://aka.ms/new-console-template for more information


using Labwork3;

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

Book book3 = new Book();
book3.Name = "7 ogul isterem";
book3.Price = 45;
book3.AutorName = "Zeynal";
book3.Genre = GenreEnums.Action;



Library library1 = new Library();


library1.RemoveAll(lib => lib.Price != 45);

Console.WriteLine(library1.FilterbyPrice(15, 50));
Console.WriteLine(library1.FilterbyGenre(GenreEnums.Detective));
Console.WriteLine(library1.FindBookByNo(2));
Console.WriteLine(library1.IsExistBookByNo(4));