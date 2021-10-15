using BookBorrow.Models;
using BookBorrow.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrow.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMember _memberRepo;
       
        public MemberController(IMember memberRepo)
        {
            _memberRepo = memberRepo;
        }
        public ViewResult Memberlist()
        {
            var model = _memberRepo.GetAllMembers();
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult All()
        {
            var model = _memberRepo.GetAllMembers();

            return View(model);
        }
        public IActionResult Create(int? id)
        {
            Member member = new Member();
            if (id == null)
            {
                return View(member);
            }

            member = _memberRepo.GetMember((int)id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
               
                    _memberRepo.Add(member);

              
          
            }
            return RedirectToAction("All");

        }
       [HttpPost]
        public IActionResult Update(Member member ,int value)
        {
            _memberRepo.Update(member);
            var m = _memberRepo.GetMember(value);
            return RedirectToAction("All");
        }
        [HttpPost]
        public IActionResult Delete(int value)
        {
            _memberRepo.Delete(value);
            return RedirectToAction("All");
        }

    }
}
