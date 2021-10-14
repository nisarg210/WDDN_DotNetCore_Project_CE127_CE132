using BookBorrow.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrow.Models.Repository
{
    public class SQLMemberRepo: IMember
    {
        private readonly AppDBContext _db;
        public SQLMemberRepo(AppDBContext db)
        {
            _db = db;
        }

        Member IMember.Add(Member member)
        {
            _db.Member.Add(member);
            _db.SaveChanges();
            return member;
        }

        Member IMember.Delete(int Id)
        {
            Member member = _db.Member.Find(Id);
            if (member != null)
            {
                _db.Member.Remove(member);
                _db.SaveChanges();
            }
            return member;
        }

        IEnumerable<Member> IMember.GetAllMembers()
        {
            return _db.Member;
        }

        Member IMember.GetMember(int Id)
        {
            return _db.Member.Find(Id);
        }

        Member IMember.Update(Member memberChanges)
        {
            var member = _db.Member.Update(memberChanges);
            _db.SaveChanges();
            return memberChanges;
        }
    }
}
