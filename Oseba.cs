using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_franci2
{
    public class Oseba
    {
        public string IP;
        public int starost;
        public PostniNaslov pn;
        public List<Oseba> prijatelji;

        public Oseba()
        {
            Console.WriteLine("Oseba ustvarjena!");
        }

        public Oseba(string IP, int starost, PostniNaslov pn)
        {
            this.prijatelji = new List<Oseba>();
            this.IP = IP;
            this.starost = starost;
            this.pn = pn;
        }

        public string VrniIP()
        {
            return IP;
        }

        public void MojIzpis()
        {
            Console.WriteLine("Ime Priimek:{0} Starost:{1}", IP, starost);
            pn.MojIzpis();
        }

        public int SteviloPrijateljev()
        {
            return prijatelji.Count;
        }

        public bool JePrijateljOd(Oseba oseba)
        {
            foreach(Oseba os in prijatelji)
            {
                if(os.IP == oseba.IP)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool VzpostaviPrijateljstvo(Oseba prva, Oseba druga)
        {
            if(prva != druga && !prva.JePrijateljOd(druga))
            {
                prva.prijatelji.Add(druga);
                druga.prijatelji.Add(prva);

                return true;
            }

            else
            {
                return false;
            }
        }

        public bool NaIstemNaslovuKot(Oseba os)
        {
            if (pn.JeEnakoKot(os.pn))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int SteviloPrijateljevNaIstem()
        {
            int st = 0;
            foreach(Oseba os in prijatelji)
            {
                if (NaIstemNaslovuKot(os))
                {
                    st++;
                }
            }

            return st;
        }

        public Oseba NajstarejsiPrijetelj()
        {
            if(prijatelji.Count == 0)
            {
                return null;
            }

            Oseba oseba = prijatelji[0];

            foreach(Oseba os in prijatelji)
            {
                if(os.starost > oseba.starost)
                {
                    oseba = os;
                }
            }

            return oseba;
        }
    }
}
