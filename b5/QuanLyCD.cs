using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b5
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;
        public QuanLyCD()
        {
            ds = new CD[25];
            n = 0;

        }
        public QuanLyCD (int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;

        }
        public void themcd(CD cd)
        {
            if(n>= ds.Length)
            {
                Console.Write("danh sach da day");
            }
            else
            {
                if (!kiemtratrungCD(cd.Macd)) 
                    ds[n++] = cd;
                else
                {
                    Console.Write("trung ma CD");
                }
                    
            }
        }
        private bool kiemtratrungCD(int macd)
        {
            for(int i = 0; i < n; i++)
            {
                if(ds[i].Macd == macd)
                {
                    return true;
                }    
            }
            return false;
        }
        public double tinhgiatritrungbinh()
        {
            int tonggia = 0;
            for(int i = 0; i<n;i++)
            {
                tonggia += ds[i].dongia;
            }
            return (double)tonggia / n;
        }
        public void sxgtheogiathanh()
        {
            CD x;
            for(int i = 0; i<n-1;i++)
            {
                for (int j = 0; j < n; j++)
                    if (ds[i].dongia < ds[j].dongia)
                    {
                        x = ds[i];
                        ds[i] = ds[j];
                        ds[j] = x;

                    }    
            }    
        }
        public void sxttheotuacd()
        {
            CD x;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                    if (ds[i].Tuacd.CompareTo (ds[j].Tuacd)>0)
                    {
                        x = ds[i];
                        ds[i] = ds[j];
                        ds[j] = x;

                    }
            }
        }
        public void xuat()
        {
            Console.WriteLine("{0,5} {1,20} {2,10} {3,10} {4,10}","macd","tuacd","casy","sobaihat","dongia");
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine(ds[i].tostring());
            }    

        }
    }
}
