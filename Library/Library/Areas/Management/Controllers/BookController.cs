using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Library.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy ="AdminPolicy")]
    public class BookController : Controller
    {
        MyDbContext _db;
        IBookRepository _repoBook;
        IAuthorRepository _repoAuthor;
        IBookTypeRepository _repoBookType;
        public BookController(MyDbContext db, IBookRepository repoBook, IAuthorRepository repoAuthor, IBookTypeRepository repoBookType)
        {
            _db = db;
            _repoBook = repoBook;
            _repoAuthor = repoAuthor;
            _repoBookType = repoBookType;
        }

        public IActionResult BookList()
        {
            List<Book> books = _repoBook.GetBooks();
            return View(books);
        }

        public IActionResult Create()
        {
            List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();

            List<BookTypeDto> bookTypes = _repoBookType.SelectBookTypeDto();

            return View((new Book(), authors, bookTypes));
        }


        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Book book)
        {

            _repoBook.Add(book);

            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }

        public IActionResult Delete(int id)
        {
            var x = _db.Books.Find(id);
            _db.Books.Remove(x);
            _db.SaveChanges();
            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }
    }
}
