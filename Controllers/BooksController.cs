using LibraryManegament.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManegament.Controllers
{
    public class BooksController : Controller
    {
        private static List<Book> books = new List<Book>();

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = books.Count + 1;
                books.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        public IActionResult Edit(int id)
        {
            var book = books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book updatedBook)
        {
            var book = books.Find(b => b.Id == updatedBook.Id);
            if (book == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                book.Title = updatedBook.Title;
                book.Author = updatedBook.Author;
                book.Year = updatedBook.Year;
                book.Copies = updatedBook.Copies;
                return RedirectToAction("Index");
            }
            return View(updatedBook);
        }

        public IActionResult Delete(int id)
        {
            var book = books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            books.Remove(book);
            return RedirectToAction("Index");
        }
    }
}
