using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_franci2
{
    public class Knjižnica
    {
        public string naziv;
        List<Knjiga> seznam_k;
        List<Clan> clani;
        List<Zaposleni> zaposleni;

        public Knjižnica()
        {
            this.seznam_k = new List<Knjiga>();
            this.clani = new List<Clan>();
            this.zaposleni = new List<Zaposleni>();
        }

        public Knjižnica(string naziv) : this()
        {
            this.naziv = naziv;
        }

        public void IzpisClanovBrezClanarine()
        {
            foreach(Clan clan in clani)
            {
                if(clan.clanarina == false)
                {
                    clan.MojIzpis();
                }
            }
        }

        public void IsciKnjigoPoZvrsteh(Zvrst zvrst)
        {
            foreach(Knjiga knjiga in seznam_k)
            {
                if(knjiga.zvrst == zvrst)
                {
                    knjiga.MojIzpis();
                }
            }
        }

        public int ObnoviClane()
        {
            int stevec = 0;

            foreach(Clan clan in clani)
            {
                if(clan.clanarina == true)
                {
                    clan.clanarina = false;
                    stevec++;
                }
            }

            return stevec;
        }

        public List<Zaposleni> IsciZaposlene(int max_doba)
        {
            List<Zaposleni> nov_seznam = new List<Zaposleni>();

            foreach(Zaposleni zap in zaposleni)
            {
                if(zap.delovna_doba <= max_doba)
                {
                    nov_seznam.Add(zap);
                }
            }

            return nov_seznam;
        }

        public string IsciKnjigo(string iskani_naslov)
        {
            foreach(Knjiga knj in seznam_k)
            {
                if(knj.naslov == iskani_naslov)
                {
                    return knj.naslov;
                }
            }

            return null;
        }

        public void IsciClane(DateTime datum_zad_prid)
        {
            foreach(Clan clan in clani)
            {
                if(clan.d_prid < datum_zad_prid)
                {
                    clan.MojIzpis();
                }
            }
        }

        public void DodajClana(Clan nov_clan)
        {         
            nov_clan.d_prid = new DateTime().Date;
            clani.Add(nov_clan);
        }

        public void DodajZaposlenega(Zaposleni nov_zap)
        {
                nov_zap.d_zap = new DateTime().Date;
                zaposleni.Add(nov_zap);
        }

        public bool DodajKnjigo(string naziv, Zvrst zvrst, int st_strani)
        {
            if(IsciKnjigo(naziv) != null)
              {
                    return false;
              }
                
            Knjiga nova = new Knjiga();

            nova.naslov = naziv;
            nova.zvrst = zvrst;
            nova.st_strani = st_strani;

            seznam_k.Add(nova);

            return true;

        }
    }
}
