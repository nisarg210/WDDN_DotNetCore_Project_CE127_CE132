using BookBorrow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BookBorrow.Models.Interface;

namespace BookBorrow.Models
{
    public class SQLBookRepo: IBook
    {
        private readonly AppDBContext _db;
        public SQLBookRepo(AppDBContext db)
        {
            _db = db;
        }
        Book IBook.GetBook(int Id)
        {

            return _db.Book.Find(Id);
        }
        IEnumerable<Book> IBook.GetAllBooks()
        {
            return _db.Book;
        }
        Book IBook.Add(Book book)
        {
            _db.Book.Add(book);
            _db.SaveChanges();
            return book;
        }
        Book IBook.Update(Book bookChanges)
        {
            var book = _db.Book.Attach(bookChanges);
            book.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return bookChanges;
        }
        Book IBook.Delete(int Id)
        {
            Book book = _db.Book.Find(Id);
            if (book != null)
            {
                _db.Book.Remove(book);
                _db.SaveChanges();
            }
            return book;
        }
    }
}
