namespace BookCatalog.EF;
using BookCatalog.DAL;

public class Program
{
    static void Main(string[] args)
    {
        using var dc = new BookContext(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Initial Catalog=BookCatalog2");
        DBFiller.Fill(dc);
    }
}
