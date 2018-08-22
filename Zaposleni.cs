using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_franci2
{
    public class Zaposleni : Oseba
    {
        public DateTime d_zap;
        public int delovna_doba;

        public Zaposleni()
        {
            this.d_zap = new DateTime();
            this.delovna_doba = 0;
        }

        public Zaposleni(DateTime d_zap, int delovna_doba, string IP, int starost, PostniNaslov pn) : base(IP, starost, pn)
        {
            this.d_zap = d_zap;
            this.delovna_doba = delovna_doba;
        }
    }
}
