using BookBorrow.Models;
using BookBorrow.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookBorrow.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private readonly IBook _bookRepo;
        public BookController(IBook bookRepo)
        {
            _bookRepo = bookRepo;
        }

        
        public ViewResult All()
        {
            var model = _bookRepo.GetAllBooks();
           
            return View(model);
        }
        public IActionResult Create(int? id)
        {
            Book book = new Book();
            if (id == null)
            {
                return View(book);
            }
            
            book = _bookRepo.GetBook((int)id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepo.Add(book);
            }
            return RedirectToAction("All");
            
        }
    }
}
