using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.View;
namespace Model.Dao
{
    public  class KhachHangDao
    {
        Model1 model = null;
        public KhachHangDao()
        {
            model = new Model1();
        }
        public List<KhachHang> load()
        {
           return model.KhachHangs.Where(s=>s.Status==true).ToList();
        }
        public List<KhachHang> tolist(string a)
        {
            int x = Convert.ToInt32(a);
            var result= model.KhachHangs.Where(y => y.MaKH == x);
            return result.ToList();
        }
        public List<KhachHang> search(string x)
        {
            return model.KhachHangs.Where(s => s.TenKH == x).ToList();
        }
        public void themkhachhang(string a,string b, string c, string d)
        {
            KhachHang ks = new KhachHang();
            ks.TenKH = a;
            ks.CMND = b;
            ks.NgheNghiep = c;
            ks.DiaChi = d;
            ks.Status = true;
            model.KhachHangs.Add(ks);
            model.SaveChanges();

        }
        public void suakhachhang(string a,string b,string c,string d,string e)
        {
            var f = Convert.ToInt32(a);
            var ks = model.KhachHangs.FirstOrDefault(s=>s.MaKH==f);
            ks.TenKH = b;
            ks.CMND = c;
            ks.NgheNghiep = d;
            ks.DiaChi = e;
            model.SaveChanges();
        }
        public void xoakhachhang(string a)
        {
            var f = Convert.ToInt32(a);
            var ks = model.KhachHangs.FirstOrDefault(s => s.MaKH == f);
            ks.Status = false;
            model.SaveChanges();
        }
        public KhachHang tenKH(string MaKH)
        {
            int k = Convert.ToInt32(MaKH);
            return model.KhachHangs.FirstOrDefault(x => x.MaKH == k);
        }
        public KhachHang getTTKH(string MaKH)
        {
            int y = Convert.ToInt32(MaKH);
            return model.KhachHangs.Find(y);
        }
    }
}
