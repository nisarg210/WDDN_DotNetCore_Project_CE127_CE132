using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrow.Models
{
    public class Book 
    {
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public List<BookIssue> BookIssue { get; set; }
    }
}
