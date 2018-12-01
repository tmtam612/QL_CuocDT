using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.Dao
{
    public class HoaDonDangKyDao
    {
        Model1 model = null;
        public HoaDonDangKyDao()
        {
            model = new Model1();
        }
        public string search(string a)
        {
            int x = Convert.ToInt32(a);
            var result1 = model.HoaDonDKs.Include("KhachHang").Include("Sim").FirstOrDefault(s => s.MaSim == x).MaKH;
            var result = model.KhachHangs.FirstOrDefault(y => y.MaKH == result1).TenKH;
            return result;
        }
        public List<HoaDonDK> load()
        {
            return model.HoaDonDKs.Include("KhachHang").Include("Sim").ToList();
        }
        public string timsosim(string a)
        {
            int x = Convert.ToInt32(a);
            var result = model.HoaDonDKs.Include("Sim").FirstOrDefault(y => y.MaSim == x).Sim.SoSim;
            return result.ToString();
        }
        public string timtenkh(string a)
        {
            int x = Convert.ToInt32(a);
            var result = model.HoaDonDKs.Include("KhachHang").FirstOrDefault(y => y.MaKH == x).KhachHang.TenKH;
            return result.ToString();
        }
        public void Them(string a,string b, string c,string d)
        {
            HoaDonDK hd = new HoaDonDK();
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);
            DateTime z = Convert.ToDateTime(c);
            Decimal u = Convert.ToDecimal(d);
            hd.MaKH = x;
            hd.MaSim = y;
            hd.TG_DangKy = z;
            hd.ChiPhi = u;
            model.HoaDonDKs.Add(hd);
            var result = model.Sims.FirstOrDefault(k => k.MaSim == y);
            result.Status = true;
            model.SaveChanges();
        }
        public void xoa(string a)
        {
            int x = Convert.ToInt32(a);
            var result = model.HoaDonDKs.FirstOrDefault(y => y.MaHD == x);
            model.HoaDonDKs.Remove(result);
            model.SaveChanges();
        }
        public void sua(string MaHDDK,string MAKH,string MaSim,string TG_DangKy,string ChiPhi)
        {
            int x = Convert.ToInt32(MaHDDK);
            int z = Convert.ToInt32(MAKH);
            int u = Convert.ToInt32(MaSim);
            DateTime k = DateTime.ParseExact(TG_DangKy,"dd/MM/yyyy HH:mm:ss",null);
            Decimal h = Convert.ToDecimal(ChiPhi);
            var result = model.HoaDonDKs.FirstOrDefault(y => y.MaHD == x);
            var result2 = model.Sims.FirstOrDefault(y => y.MaSim == result.MaSim);
            result2.Status = false;
            result.MaKH = z;
            result.MaSim = u;
            result.TG_DangKy = k;
            result.ChiPhi = h;
            model.SaveChanges();
        }
    }
}
