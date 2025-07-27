using System.ComponentModel.DataAnnotations;

namespace BooKCatalog.MVC.Models;


public class BookModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public int Year { get; set; }
}
