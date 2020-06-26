using AdminTET.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminTET.Controllers
{
    [PageAuthorize]
    public class FileUploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FileList()
        {
            return View();
        }
    }
}