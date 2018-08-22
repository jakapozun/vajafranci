using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_franci2
{
    public class Clan : Oseba
    {
        public DateTime d_prid;
        public bool clanarina;

        public Clan()
        {
            this.d_prid = new DateTime();
            this.clanarina = false;
        }

        public Clan(DateTime d_prid, bool clanarina, string IP, int starost, PostniNaslov pn) : base(IP, starost, pn)
        {
            this.d_prid = d_prid;
            this.clanarina = clanarina;
        }


    }
}
