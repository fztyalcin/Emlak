using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak
{
    public class Emlak
    {
        public long ID;
        public Adres Adres;
        public string Sahibi;
        public int Fiyat;
        public DateTime İlanTarihi;
        public decimal M2;
        public bool KrediyeUygunMu;
        public bool SahibindenMi;

    }

    public class Konut : Emlak
    {
        public int OdaSayisi;
        public string Cephe;
        public int BinaYasi;
        public string Isitma;
        public bool BalkonVarMi;
        public bool SiteIcindeMi;
        public int Aidat;
    }

    public class Ev : Konut
    {
        public int Kat;
        public int BinaKatSayisi;
    }

    public class Arsa : Emlak 
    {
        public bool ImarliMi;
        public int Ada;
        public int Parsel;

    }

    public class Villa : Konut 
    {
        public decimal BahceM2;
        public bool HavuzVarMi;

    }



    public class KiralikEv : Ev 
    {
        public KiralikEmlakBilgileri KiralikBilgiler;
    }

    public class SatilikEv : Ev { }


    public class SatilikArsa : Arsa { }

    public class KiralikArsa : Arsa 
    {
        public KiralikEmlakBilgileri KiralikBilgiler;
    }


    public class SatilikVilla : Villa 
    {

    }

    public class KiralikVilla : Villa 
    {
        public KiralikEmlakBilgileri KiralikBilgiler;
    }


    public class KiralikEmlakBilgileri 
    {
        public decimal Depozito;
        public int KontratSuresi;
        public string Kefil;
    }

    public class Adres
    {
        public Semt Semt;
        public string Cadde;
        public string Sokak;
        public int BinaNo;
        public int DaireNo;
    }

    public class Sehir
    {
        public int Kod;
        public string Ad;
    }

    public class Semt
    {
        public int Kod;
        public string Ad;
        public Sehir Sehir;
    }

    public class Musteriler
    {
        public string Ad;
        public string SoyAd;
        public IletisimBilgi IletisimBilgi;

    }

    public class IletisimBilgi
    {
        public string TelNo1;
        public string TelNo2;
        public string EvTel;
        public string Eposta;
        public string Fax;

    }

}
