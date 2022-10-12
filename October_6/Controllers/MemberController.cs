using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using October_6.Models;

namespace October_6.Controllers
{
    public class MemberController : Controller
    {

        static List<Member> MemberList = new List<Member>();
        static MemberController()
        {
            MemberList.Add(new Member { MemberId = 1, MemberName = "ram", AccOpenDate = new DateTime(2021, 08, 13) });

            MemberList.Add(new Member { MemberId = 2, MemberName = "prem", AccOpenDate = new DateTime(2022, 05, 13) });
            MemberList.Add(new Member { MemberId = 3, MemberName = "suraj", AccOpenDate = new DateTime(2021, 06, 23) });
        }

        // GET: Member
        public ActionResult Index()
        {
            ViewBag.msg = "List Of Members";
            return View(MemberList);
        }
    }
}