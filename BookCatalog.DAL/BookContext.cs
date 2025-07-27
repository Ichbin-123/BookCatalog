using Microsoft.EntityFrameworkCore;
using BookCatalog.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.DAL;

public class BookContext : DbContext
{
    private readonly String _connectionString;
    public BookContext(String connectionString= "Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;Initial Catalog=BookCatalog2")
    {
        _connectionString = connectionString;
    }

    public BookContext(DbContextOptions<BookContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Book => Set<Book>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(_connectionString);
        }
    }
}
