using BooKCatalog.MVC.Models;
using BookCatalog.MVC.Data.Models;


using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BooKCatalog.MVC.Extensions;

public static class ModelExtensions
{
   public static BookModel ToBookModel(this Book book)
    {
        return new BookModel
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            Year = book.Year
        };
    }
}
