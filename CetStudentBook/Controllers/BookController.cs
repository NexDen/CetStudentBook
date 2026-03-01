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

    [HttpPost]
    public IActionResult Create(Book book)
    {
        

        _context.Books.Add(book);
    }
}