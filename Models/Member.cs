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
        public string MemberName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public int Pincode { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
