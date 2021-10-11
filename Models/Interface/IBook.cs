using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrow.Models.Interface
{
    public interface IBook
    {
        Book GetBook(int Id);
        IEnumerable<Book> GetAllBooks();
        Book Add(Book book);
        Book Update(Book bookChanges);
        Book Delete(int Id);
    }
}
