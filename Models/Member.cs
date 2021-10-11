using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrow.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
    }
}
