using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quan_Ly_Tour_Du_Lich.Areas.Admin.Controllers
{
    public class KhuyenMaiController : Controller
    {
        // GET: Admin/KhuyenMai
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add_KhuyenMai()
        {
            return View();
        }
    }
}