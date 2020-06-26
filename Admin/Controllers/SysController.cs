using AdminTET.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminTET.Controllers
{
    [PageAuthorize]
    public class SysController : Controller
    {
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult OrganizationalStructure()
        {
            return View();
        }
        public ActionResult Roles()
        {
            return View();
        }
        public ActionResult Permission()
        {
            return View();
        }
        public ActionResult DataDictionary()
        {
            return View();
        }
        public ActionResult BusinessMember()
        {
            return View();
        }
        public ActionResult Agent()
        {
            return View();
        }
        public ActionResult HolidaySetting()
        {
            return View();
        }
        public ActionResult SystemLog()
        {
            return View();
        }
    }
}