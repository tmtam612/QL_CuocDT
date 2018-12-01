using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class CuocGoiDao
    {
        Model1 model = null;
        public CuocGoiDao()
        {
            model = new Model1();
        }
        public List<CuocGoi> Load()
        {
            return model.CuocGois.Include(s => s.Sim).Where(s=>s.Sim.Status==true).ToList();
        }
        public void them(string a,string b,string c)
        {
            int x = Convert.ToInt32(a);
            DateTime y = DateTime.ParseExact(b,"dd/MM/yyyy HH:mm:ss",null);
            DateTime z = DateTime.ParseExact(c, "dd/MM/yyyy HH:mm:ss", null);
            CuocGoi cg = new CuocGoi();
            double p = z.Subtract(y).TotalSeconds/60;
            int s = Convert.ToInt32(p);
            cg.SoPhutSD = s;
            cg.MaSim = x;
            cg.TG_BatDau = y;
            cg.TG_KetThuc = z;
            cg.trangthai = false;
            model.CuocGois.Add(cg);
            model.SaveChanges();
        }
        public int check(string a,string b,string c)
        {
            int x = Convert.ToInt32(a);
            DateTime y = DateTime.ParseExact(b, "dd/MM/yyyy HH:mm:ss", null);
            DateTime z = DateTime.ParseExact(c, "dd/MM/yyyy HH:mm:ss", null);
            var search = model.CuocGois.Where(h => h.MaSim == x).ToList();
            foreach(var item in search)
            {
                if (item.TG_BatDau.CompareTo(y)==0&&item.TG_KetThuc.CompareTo(z)==0)
                {
                    return -1;
                }
            }
            return 1;
        }
        public List<CuocGoi> GetCuocGois(int MaSim)
        {
            return model.CuocGois.Where(x => x.MaSim == MaSim).ToList();
        }
        
    }
}
