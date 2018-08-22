using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_franci2
{
    public enum Zvrst { neznano, kriminalka, grozljivka, roman};
    public class Knjiga
    {
        public string naslov;
        public Zvrst zvrst;
        public int st_strani;

        public Knjiga()
        {
            this.naslov = "";
            this.zvrst = 0;
            this.st_strani = 0;
        }

        public Knjiga(string naslov, Zvrst zvrst, int st_strani)
        {
            this.naslov = naslov;
            this.zvrst = zvrst;
            this.st_strani = st_strani;
        }

        public void MojIzpis()
        {
            Console.WriteLine(naslov + " " + zvrst + " " + st_strani);
        }


    }
}
