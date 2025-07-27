using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.MVC.Data.Models;

public class Book
{
    public int Id { get; set; }
    [Required]
    [MaxLength(350)]
    public string? Title { get; set; }

    [Required]
    [MaxLength(120)]
    public string? Author { get; set; }

    [Required]
    public int Year { get; set; }
}
