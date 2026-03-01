using CetStudentBook.Data;
using CetStudentBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace CetStudentBook.Controllers;

public class BookController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public BookController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Book book)
    {
        var tz = book.PublishDate.ToUniversalTime();
        book.PublishDate = tz; // aşırı garip bir postgresql timestamptz hatasını çözmek için
        _context.Books.Add(book);
        _context.SaveChangesAsync();
        return View(book);
    }

    [HttpPost]
    public IActionResult Edit(Book book)
    {
        throw new NotImplementedException();
    }
    
    public IActionResult Edit()
    {
        return View();
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IActionResult Details(int id)
    {
        throw new NotImplementedException();
    }

    public IActionResult Index()
    {
        var books = _context.Books.ToList();
        return View(books);
    }
}