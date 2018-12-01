using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.View;
namespace Model.Dao
{
    public class HoaDonThanhToanDao
    {
        Model1 model = null;
        public HoaDonThanhToanDao()
        {
            model = new Model1();
        }
        public List<HoaDonThanhToan> load()
        {
            return model.HoaDonThanhToans.Where(s => s.Status == true).ToList();
        }
        public string timsosim(string a)
        {
            int x = Convert.ToInt32(a);
            var result = model.HoaDonThanhToans.Include("Sim").FirstOrDefault(y => y.MaSim == x).Sim.SoSim;
            return result.ToString();
        }
        public string timtenkh(string a)
        {
            int x = Convert.ToInt32(a);
            var result = model.HoaDonThanhToans.Include("KhachHang").FirstOrDefault(y => y.MaKH == x).KhachHang.TenKH;
            return result.ToString();
        }
        public List<KhachHangView> themhd()
        {
            var kh = from a in model.CuocGois
                     join b in model.Sims on a.MaSim equals b.MaSim
                     join c in model.HoaDonDKs on b.MaSim equals c.MaSim
                     join d in model.KhachHangs on c.MaKH equals d.MaKH
                     where a.trangthai == false
                     group new { a, b, c, d } by new { d.MaKH, b.MaSim } into gr
                     select new KhachHangView
                     {
                         MaKH = gr.Key.MaKH,
                         MaSim = gr.Key.MaSim
                     };
            return kh.ToList();
        }
        public void them(KhachHangView kh)
        {
            HoaDonThanhToan hd = new HoaDonThanhToan();
            hd.MaKH = kh.MaKH;
            hd.MaSim = kh.MaSim;
            hd.CuocThueBao = 50000;
            hd.TG_TaoHoaDon = DateTime.Now;
            hd.ThanhToan = false;
            hd.Status = true;
            var result1 = model.CuocGois.Where(x => x.MaSim == kh.MaSim).Where(x => x.trangthai == false).ToList();
            TimeSpan ts1 = new TimeSpan(7, 0, 0);
            TimeSpan ts2 = new TimeSpan(23, 0, 0);
            hd.ThanhTien = 0;
            decimal thanhtien = 0;
            foreach (var item in result1)
            {
                if (item.TG_BatDau.TimeOfDay.Subtract(ts1).TotalSeconds > 0 && ts2.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds > 0)
                {
                    if (ts2.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds > 0 && item.TG_KetThuc.TimeOfDay.Subtract(ts1).TotalSeconds > 0)
                    {
                        thanhtien +=  item.SoPhutSD * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts1) == 0).GiaCuoc;
                    }
                    else
                    {
                        int temp = new int();
                        if (ts2.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds < 0)
                        {
                            temp = Convert.ToInt32(item.TG_KetThuc.TimeOfDay.Subtract(ts2).TotalSeconds / 60);

                        }
                        if (item.TG_KetThuc.TimeOfDay.Subtract(ts1).TotalSeconds < 0)
                        {
                            temp = Convert.ToInt32(ts1.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds / 60);
                        }
                        thanhtien +=  temp * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts2) == 0).GiaCuoc + (item.SoPhutSD - temp) * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts1) == 0).GiaCuoc;
                    }
                }
                else
                {
                    if (ts2.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds > 0 && item.TG_KetThuc.TimeOfDay.Subtract(ts1).TotalSeconds > 0)
                    {
                        int temp = Convert.ToInt32(item.TG_KetThuc.TimeOfDay.Subtract(ts1).TotalSeconds / 60);
                        thanhtien +=  (item.SoPhutSD - temp) * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts2) == 0).GiaCuoc + temp * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts1) == 0).GiaCuoc;
                    }
                    else
                    {
                       thanhtien +=  item.SoPhutSD * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts2) == 0).GiaCuoc;
                    }
                }
                item.trangthai = true;
            }
            hd.ThanhTien = hd.CuocThueBao + thanhtien;
            model.HoaDonThanhToans.Add(hd);
            model.SaveChanges();
        }
        public void thanhtoan(string a)
        {
            int y = Convert.ToInt32(a);
            var result = model.HoaDonThanhToans.FirstOrDefault(x => x.MaHD == y);
            result.ThanhToan = true;
            model.SaveChanges();
        }
        public void xoa(string a)
        {
            int y = Convert.ToInt32(a);
            var result = model.HoaDonThanhToans.FirstOrDefault(x => x.MaHD == y);
            result.Status = false;
            model.SaveChanges();
        }
        public List<HoaDonThanhToan> hdttTheoMAKH(int MaKH)
        {
            return model.HoaDonThanhToans.Where(x => x.MaKH == MaKH && x.Status == true).ToList();
        }
        public int getMaSim(int MaHD)
        {
            var result = model.HoaDonThanhToans.FirstOrDefault(x => x.MaHD == MaHD);
            return result.MaSim;
        }
        public decimal CuocThueBao()
        {
            return model.HoaDonThanhToans.First().CuocThueBao;
        }
        public decimal thanhtien(int MaCuocGoi)
        {
            decimal thanhtien=0;
            var item = model.CuocGois.FirstOrDefault(x=>x.MaCuocGoi==MaCuocGoi);
            TimeSpan ts1 = new TimeSpan(7, 0, 0);
            TimeSpan ts2 = new TimeSpan(23, 0, 0);
            if (item.TG_BatDau.TimeOfDay.Subtract(ts1).TotalSeconds > 0 && ts2.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds > 0)
                {
                    if (ts2.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds > 0 && item.TG_KetThuc.TimeOfDay.Subtract(ts1).TotalSeconds > 0)
                    {
                        thanhtien = item.SoPhutSD * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts1) == 0).GiaCuoc;
                        return thanhtien;
                    }
                    else
                    {
                        int temp = new int();
                        if (ts2.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds < 0)
                        {
                            temp = Convert.ToInt32(item.TG_KetThuc.TimeOfDay.Subtract(ts2).TotalSeconds / 60);

                        }
                        if (item.TG_KetThuc.TimeOfDay.Subtract(ts1).TotalSeconds < 0)
                        {
                            temp = Convert.ToInt32(ts1.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds / 60);
                        }
                        thanhtien = temp * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts2) == 0).GiaCuoc + (item.SoPhutSD - temp) * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts1) == 0).GiaCuoc;
                        return thanhtien;
                    }
                }
            else
                {
                    if (ts2.Subtract(item.TG_KetThuc.TimeOfDay).TotalSeconds > 0 && item.TG_KetThuc.TimeOfDay.Subtract(ts1).TotalSeconds > 0)
                    {
                        int temp = Convert.ToInt32(item.TG_KetThuc.TimeOfDay.Subtract(ts1).TotalSeconds / 60);
                        thanhtien =  (item.SoPhutSD - temp) * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts2) == 0).GiaCuoc + temp * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts1) == 0).GiaCuoc;
                        return thanhtien;
                    }
                    else
                    {
                        thanhtien = item.SoPhutSD * model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau.CompareTo(ts2) == 0).GiaCuoc;
                        return thanhtien;
                    }
                }            
            return thanhtien;
        }
    }
}
