using BookBorrow.Models;
using BookBorrow.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrow.Controllers
{
    public class BookIssueController : Controller
    {
        private readonly IBook _bookRepo;
        private readonly IMember _memberRepo;
        private readonly AppDBContext _db;
        public BookIssueController(IBook bookRepo, IMember memberRepo, AppDBContext db)
        {
            _bookRepo = bookRepo;
            _memberRepo = memberRepo;
            _db = db;
        }
        public IActionResult Issue()
        {
            dynamic mymodel = new ExpandoObject();
            var model = _bookRepo.GetAllBooks();
            var allBookIssued = _db.BookIssue;
            mymodel.book = model;
            mymodel.Blist = model.ToList();
            mymodel.IssueList = allBookIssued.ToList();
            return View(mymodel);
        }
        [HttpPost]
        public IActionResult Add(int dp,int mid,DateTime s,DateTime e)
        {
            var bookname = _bookRepo.GetBook(dp);
            var memname = _memberRepo.GetMember(mid);
            BookIssue book = new BookIssue();
            book.BookID = dp;
            book.MemberId = mid;
            book.BookName = bookname.BookName;
            book.Name = memname.MemberName;
            book.Start = s;
            book.End = e;
            _db.BookIssue.Add(book);
            _db.SaveChanges();
            ViewBag.d = dp;
            ViewBag.m = mid;
            return RedirectToAction("Issue");
        }
        [HttpPost]
        public IActionResult Return(int value)
        {
            BookIssue book = _db.BookIssue.Find(value);
            _db.BookIssue.Remove(book);
            _db.SaveChanges();

            return RedirectToAction("Issue");
        }
    }
}
