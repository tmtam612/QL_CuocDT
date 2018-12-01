using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
namespace QL_CuocDT.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult OK()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Index")]
        public ActionResult Submit(string id)
        {
            KhachHangDao kh = new KhachHangDao();
            var result=kh.getTTKH(id);
            if(result==null)
            {
                return View();
            }
            else
            {
                Session["MaKH"] = result.MaKH;
                return RedirectToAction("Xuat",result);
            }
        }
        public ActionResult Xuat(KhachHang khachHang)
        {
            KhachHang result = new KhachHang();
            result = khachHang;
            return View(result);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}