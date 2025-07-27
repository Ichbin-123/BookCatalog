using System.ComponentModel.DataAnnotations;

namespace BookCatalog.MVC.Models;

public class BookDTO
{

    [Required]
    [MaxLength(350)]
    public string? Title { get; set; }

    [Required]
    [MaxLength(120)]
    public string? Author { get; set; }

    [Required]
    public int Year { get; set; }
}
