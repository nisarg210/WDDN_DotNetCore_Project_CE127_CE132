using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrow.Models
{
    public class BookIssue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BookName { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
