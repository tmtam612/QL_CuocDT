using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.Dao
{
    public class SimDao
    {
        Model1 model = null;
		public SimDao()
        {
            model = new Model1();
        }
		public void ThemSim(string a)
        {
            Sim s = new Sim();
            s.SoSim = a;
            s.Status = false;
            model.Sims.Add(s);
            model.SaveChanges();
        }
		public void SuaSim(string a,string b)
        {
            var numb = Convert.ToInt32(a);
            var result = model.Sims.FirstOrDefault(s => s.MaSim == numb);
            result.SoSim = b;
            model.SaveChanges();
        }
        public void XoaSim(string a)
        {
            var numb = Convert.ToInt32(a);
            var result = model.Sims.FirstOrDefault(s => s.MaSim == numb);
            model.Sims.Remove(result);
            model.SaveChanges();
        }
        public List<Sim> Load()
        {
            return model.Sims.Where(s => s.Status == false).ToList();
        }
        public int[] random()
        {
            return model.Sims.Where(x=>x.Status==true).Select(x=>x.MaSim).ToArray();
        }
        public string laysosim(int a)
        {
            var result= model.Sims.FirstOrDefault(x => x.MaSim == a);
            return result.SoSim;
        }
        public List<Sim> loadgridcontrol()
        {
            return model.Sims.ToList();
        }
        public Sim sdt(string MaSim)
        {
            int m = Convert.ToInt32(MaSim);
            return model.Sims.FirstOrDefault(x => x.MaSim == m);
        }

    }
}
