using Microsoft.AspNetCore.Mvc;
using BooKCatalog.MVC.Models;
using Microsoft.IdentityModel.Tokens;
using BooKCatalog.MVC.Data;
using BooKCatalog.MVC.Extensions;
using BookCatalog.MVC.Models;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BooKCatalog.MVC.Controllers;

public class BooksController : Controller
{

    private readonly ApplicationDbContext _context;
    public BooksController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {

        ViewData["MessaggioTest"] = "Ciao Bello questo è un messaggio di Test";
        //List<BookModel> books = [
        //    new BookModel{
        //        Id = 12,
        //        Title = "Ciabatte con il Pelo. L'ultima frontiera della moda Impertinente",
        //        Author = "Matteo Valenzi",
        //        Year = 2025
        //    },
        //    new BookModel{
        //        Id = 13,
        //        Title = "Ciabatte da mare. I modelli più orribili della Storia Contemporanea",
        //        Author = "Matteo Valenzi",
        //        Year = 2024
        //    }
        //    ];

        var books = _context.Book
            .OrderByDescending(x => x.Id)
            .Select(b => b.ToBookModel()).ToList();
        return View(books);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(BookDTO book)
    {

        if (ModelState.IsValid)
        {
            // Salva sul DB
            try
            {
                var nuovoLibro = new BookCatalog.MVC.Data.Models.Book
                {
                    Title = book.Title,
                    Author = book.Author,
                    Year = book.Year
                };

                _context.Book.Add(nuovoLibro);
                
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View(book);
            }
            
        }
        else
        {

            return View(book);
        }

    }
}
