using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Dao;
using Model.EF;
namespace QL_CuocDT_WF
{
    public class XuLyFile
    {
        public void taofile(string a)
        {
            FileStream fs = new FileStream(a+"\\log.txt", FileMode.Create);
            using (StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8))
            {
                List<string> ds = new List<string>();
                for (int i = 0; i < 100; i++)
                {
                    DateTime x = new DateTime();
                    DateTime y = new DateTime();
                    Random r = new Random();
                    while (x.CompareTo(y) >= 0)
                    {
                        int day = new int();
                        int day2 = new int();
                        day = r.Next(1, 31);
                        if (day == 31)
                        {
                            day2 = 31;
                        }
                        else
                        {
                            int temp = day + 1;
                            day2 = r.Next(day, temp);
                        }
                        x = new DateTime(2018, 12, day, r.Next(00, 24), r.Next(00, 60), r.Next(00, 60));
                        y = new DateTime(2018, 12, day2, r.Next(00, 24), r.Next(00, 60), r.Next(00, 60));
                    }
                    SimDao s = new SimDao();
                    int[] vs = s.random();
                    int RandomSimID = vs[r.Next(vs.Length)];
                    string line = RandomSimID + "   " + x.ToString("dd/MM/yyyy HH:mm:ss") + "   " + y.ToString("dd/MM/yyyy HH:mm:ss");
                    var check = ds.Contains(line);
                    if (check == true)
                    {
                        i = i - 1;
                    }
                    else
                    {
                        ds.Add(line);
                        sWriter.WriteLine(line);
                    }
                }
            }
            fs.Close();
        }
        public int insertDB(string a)
        {
            try
            {
                string line = "";
                FileStream f = new FileStream(a, FileMode.Open);
                using (StreamReader sr = new StreamReader(f))
                {
                    CuocGoiDao cg = new CuocGoiDao();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] str = new string[3];
                        int k = 0;
                        int j = 0;
                        for (int i = 0; i < line.Length; i++)
                        {
                            if ((line[i] == ' ' && line[i + 1] == ' '))
                            {
                                str[k] = line.Substring(j, i - j);
                                k++;
                                j = i;
                                while (line[j] == ' ')
                                {
                                    j++;
                                }
                                i = j;
                            }

                        }
                        str[k] = line.Substring(j, line.Length - j);
                        if (cg.check(str[0], str[1], str[2]) == 1)
                        {
                            cg.them(str[0], str[1], str[2]);
                        }
                        else return -2;
                    }
                }
                f.Close();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
