using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
namespace QL_CuocDT.Controllers
{
    public class HoaDonThanhToansController : Controller
    {
        private Model1 db = new Model1();

        // GET: HoaDonThanhToans
       
        
        public ActionResult Index(int id)
        {
            var hoaDonThanhToans = new HoaDonThanhToanDao();
            var result = hoaDonThanhToans.hdttTheoMAKH(id);
            return View(result);
        }
        public ActionResult CTHD(int id)
        {

            HoaDonThanhToanDao hd = new HoaDonThanhToanDao();
            
            var model = hd.getMaSim(id);
            CuocGoiDao cg = new CuocGoiDao();
            var result = cg.GetCuocGois(model);
            ViewBag.CuocGia = hd.CuocThueBao();
            decimal sum = 0;
            List<decimal> thanhtien = new List<decimal>();
            foreach (var item in result)
            {
                thanhtien.Add(hd.thanhtien(item.MaCuocGoi));
                sum = sum + hd.thanhtien(item.MaCuocGoi);
            }
            sum += 50000;
            ViewBag.TongCong = sum;
            ViewBag.ThanhTien=thanhtien ;
            if(result==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            return View(result);
        }
        // GET: HoaDonThanhToans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonThanhToan hoaDonThanhToan = db.HoaDonThanhToans.Find(id);
            if (hoaDonThanhToan == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonThanhToan);
        }

        // GET: HoaDonThanhToans/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "TenKH");
            ViewBag.MaSim = new SelectList(db.Sims, "MaSim", "SoSim");
            return View();
        }

        // POST: HoaDonThanhToans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHD,MaKH,MaSim,CuocThueBao,TG_TaoHoaDon,ThanhToan,ThanhTien,Status")] HoaDonThanhToan hoaDonThanhToan)
        {
            if (ModelState.IsValid)
            {
                db.HoaDonThanhToans.Add(hoaDonThanhToan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "TenKH", hoaDonThanhToan.MaKH);
            ViewBag.MaSim = new SelectList(db.Sims, "MaSim", "SoSim", hoaDonThanhToan.MaSim);
            return View(hoaDonThanhToan);
        }

        // GET: HoaDonThanhToans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonThanhToan hoaDonThanhToan = db.HoaDonThanhToans.Find(id);
            if (hoaDonThanhToan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "TenKH", hoaDonThanhToan.MaKH);
            ViewBag.MaSim = new SelectList(db.Sims, "MaSim", "SoSim", hoaDonThanhToan.MaSim);
            return View(hoaDonThanhToan);
        }

        // POST: HoaDonThanhToans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHD,MaKH,MaSim,CuocThueBao,TG_TaoHoaDon,ThanhToan,ThanhTien,Status")] HoaDonThanhToan hoaDonThanhToan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoaDonThanhToan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "TenKH", hoaDonThanhToan.MaKH);
            ViewBag.MaSim = new SelectList(db.Sims, "MaSim", "SoSim", hoaDonThanhToan.MaSim);
            return View(hoaDonThanhToan);
        }

        // GET: HoaDonThanhToans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonThanhToan hoaDonThanhToan = db.HoaDonThanhToans.Find(id);
            if (hoaDonThanhToan == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonThanhToan);
        }

        // POST: HoaDonThanhToans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoaDonThanhToan hoaDonThanhToan = db.HoaDonThanhToans.Find(id);
            db.HoaDonThanhToans.Remove(hoaDonThanhToan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
