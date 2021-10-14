using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrow.Models.Interface
{
   public interface IMember
    {
        Member GetMember(int Id);
        IEnumerable<Member> GetAllMembers();
        Member Add(Member member);
        Member Update(Member memberChanges);
        Member Delete(int Id);
    }
}
