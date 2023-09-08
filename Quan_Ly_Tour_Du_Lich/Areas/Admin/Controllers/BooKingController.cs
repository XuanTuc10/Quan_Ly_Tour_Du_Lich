using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quan_Ly_Tour_Du_Lich.Areas.Admin.Models;
using System.Web.Mvc;

namespace Quan_Ly_Tour_Du_Lich.Areas.Admin.Controllers
{
    public class BooKingController : Controller
    {
        // GET: Admin/BooKing
        public ActionResult Index()
        {
            //1. Lay du lieu trong bang
            QL_Tour_du_lichEntities db = new QL_Tour_du_lichEntities();
            List<BOOKING> danhSachBooKing = db.BOOKING.ToList();
            return View(danhSachBooKing);
        }

        public ActionResult Add_Booking()
        {
            return View();
        }
    }
}