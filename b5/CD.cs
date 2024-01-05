using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b5
{
    class CD
    {
        private int macd;
        private string tuacd;
        private string casy;
        private int sobaihat;
        private int dongiaa;

        public CD()
        {
           
        }
        public CD(int macd)
        {
            this.macd = macd;
        }
        public CD(int macd, string tuacd, string casy, int sobaihat, int dongia)
        {
            this.macd = macd;
            this.tuacd = tuacd;
            this.casy = casy;
            this.sobaihat = sobaihat;
            this.dongia= dongia;
        }
        public int Macd
        {
            set { this.macd = value; }
            get { return macd; }
        }
        public string Tuacd
        {
            set { this.tuacd = value; }
            get { return tuacd; }
        }
        public string Casy
        {
            set { this.Casy = value ; }
            get { return casy; }
        }
        public int Sobaihat
        {
            set { this.sobaihat = value; }
            get { return sobaihat; }
        }
        public int dongia
        {
            set { this.dongia = value; }
            get { return dongia; }
        }
        public string tostring()
        {
            return string.Format("{0,5} {1,20} {2,10} {3,10} {4,10}", macd, tuacd, casy, sobaihat, dongia);
        }



    }
}
