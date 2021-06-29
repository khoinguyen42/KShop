using KShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KShop.Controllers
{
    public class KShopController : Controller
    {
        public ActionResult Home()
        {
            KShopContent context = new KShopContent();
            var listclth = context.SANPHAM.ToList().Take(8);
            return View(listclth);
        }
        public ActionResult Theloai()
        {
            KShopContent context = new KShopContent();
            var theloai = from tl in context.THELOAI select tl;
            return PartialView(theloai);
        }
        public ActionResult Sptheotl(int id)
        {
            KShopContent context = new KShopContent();
            var clth = from cl in context.SANPHAM where cl.MaTL == id select cl;
            return PartialView(clth);
        }
        public ActionResult ChitietSP(int id)
        {
            KShopContent context = new KShopContent();
            var clth = from cl in context.SANPHAM where cl.MaSP == id select cl;
            return View(clth.Single());
        }
    }
}