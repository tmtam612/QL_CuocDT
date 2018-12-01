using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.Dao
{
    public class LoaiCuocDao
    {
        Model1 model = null;
        public LoaiCuocDao()
        {
            model = new Model1();
        }
        public List<LoaiCuoc> load()
        {
            return model.LoaiCuocs.Where(x => x.Status == true).ToList();
        }
        public void ThemLoaiCuoc(string a,string b,string c)
        {
            LoaiCuoc lc = new LoaiCuoc();
            TimeSpan x = TimeSpan.Parse(a);
            TimeSpan y = TimeSpan.Parse(b);
            Decimal z = Convert.ToDecimal(c);
            lc.TG_BatDau = x;
            lc.TG_KetThuc = y;
            lc.GiaCuoc =z;
            lc.Status = true;
            model.LoaiCuocs.Add(lc);
            model.SaveChanges();
        }
        public void sualoaicuoc(string TGBD,string TGKT,string GC)
        {
            TimeSpan tgbd = TimeSpan.Parse(TGBD);
            TimeSpan tgkt =TimeSpan.Parse(TGKT);
            Decimal gc = Convert.ToDecimal(GC);
            var result = model.LoaiCuocs.FirstOrDefault(x => x.TG_BatDau == tgbd&&x.TG_KetThuc==tgkt);
            result.GiaCuoc = gc;
            model.SaveChanges();

        }
        public void XoaLoaiCuoc(string a,string b,string c)
        {
            TimeSpan x = TimeSpan.Parse(a);
            TimeSpan y = TimeSpan.Parse(b);
            Decimal z = Convert.ToDecimal(c);
            var result = model.LoaiCuocs.FirstOrDefault(s => s.TG_BatDau == x);
            model.LoaiCuocs.Remove(result);
            model.SaveChanges();
        }
    }
}
