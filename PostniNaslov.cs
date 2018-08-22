using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_franci2
{
    public class PostniNaslov
    {
        public string ulica;
        public int hisna_st;
        public int postna_stevilka;
        public string naziv_poste;

        public PostniNaslov()
        {

        }

        public PostniNaslov(string ulica, int hisna_st, int postna_stevilka, string naziv_poste)
        {
            this.ulica = ulica;
            this.hisna_st = hisna_st;
            this.postna_stevilka = postna_stevilka;
            this.naziv_poste = naziv_poste;
        }

        public void MojIzpis()
        {
            Console.WriteLine("Ulica in hišna št:{0},{1} Postna stevilka:{2} Naziv pošte:{3}", ulica, hisna_st, postna_stevilka, naziv_poste);
        }

        public bool JeEnakoKot(PostniNaslov pn)
        {
            if(hisna_st == pn.hisna_st && postna_stevilka == pn.postna_stevilka && naziv_poste == pn.naziv_poste && ulica == pn.ulica)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
