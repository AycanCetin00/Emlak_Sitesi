using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace emlak_v1
{
    public enum EvTuru
    {
        Daire,
        Bahceli,
        Dubleks,
        Mustakil
    }
    public class Ev
    {
        // Alanlar (Fields)
        private int _odaSayisi;
        private int _katNumarasi;
        private string _semt;
        private double _alani;
        private DateTime _yapimTarihi;
        private EvTuru _tur;
        private bool _aktif;
        private string _emlakNumarasi;

        // Property'ler
        public int OdaSayisi
        {
            get { return _odaSayisi; }
            set
            {
                if (value < 0)
                {
                    _odaSayisi = 0;
                    LogKaydi("Oda sayısı negatif olamaz. Oda sayısı sıfır olarak atanmıştır.");
                }
                else
                {
                    _odaSayisi = value;
                    LogKaydi("Oda sayısı güncellendi: " + value);
                }
            }
        }

        public int KatNumarasi
        {
            get { return _katNumarasi; }
            set { _katNumarasi = value; }
        }

        public string Semt
        {
            get { return _semt; }
            set { _semt = value; }
        }

        public double Alani
        {
            get { return _alani; }
            set { _alani = value; }
        }

        public DateTime YapimTarihi
        {
            get { return _yapimTarihi; }
            set { _yapimTarihi = value; }
        }

        public EvTuru Tur
        {
            get { return _tur; }
            set { _tur = value; }
        }

        public bool Aktif
        {
            get { return _aktif; }
            set { _aktif = value; }
        }

        public string EmlakNumarasi
        {
            get { return _emlakNumarasi; }
            private set { _emlakNumarasi = value; }
        }

        // Yaş Property'si
        public int Yas
        {
            get { return DateTime.Now.Year - _yapimTarihi.Year; }
        }

        // Kurucu Metot
        public Ev(int odaSayisi, int katNumarasi, string semt, double alani, DateTime yapimTarihi, EvTuru tur, bool aktif, string emlakNumarasi)
        {
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semt = semt;
            Alani = alani;
            YapimTarihi = yapimTarihi;
            Tur = tur;
            Aktif = aktif;
            EmlakNumarasi = emlakNumarasi;
        }

        // Kurucu Metot Overloading
        public Ev(int odaSayisi, int katNumarasi, string semt, double alani, DateTime yapimTarihi, EvTuru tur, bool aktif)
            : this(odaSayisi, katNumarasi, semt, alani, yapimTarihi, tur, aktif, Guid.NewGuid().ToString())
        {
        }

        // Ev Bilgileri Metodu
        public virtual string EvBilgileri()
        {
            return string.Format("Oda Sayısı: {0}, Kat Numarası: {1}, Semt: {2}, Alanı: {3}, Yapım Tarihi: {4}, Türü: {5}, Aktif: {6}, Emlak Numarası: {7}, Yaş: {8}",
                OdaSayisi, KatNumarasi, Semt, Alani, YapimTarihi.ToShortDateString(), Tur, Aktif, EmlakNumarasi, Yas);
        }

        // Fiyat Hesapla Metodu
        public double FiyatHesapla(int odaSayisi)
        {
            double katsayi = 200; // Varsayılan katsayı

            // Dosya varsa ve içeriği okunabiliyorsa katsayıyı dosyadan oku
            if (File.Exists("room_cost.txt"))
            {
                try
                {
                    string dosyaIcerigi = File.ReadAllText("room_cost.txt");
                    katsayi = double.Parse(dosyaIcerigi);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Dosya okunurken hata oluştu: " + ex.Message);
                }
            }

            // Kira fiyatını hesapla ve geri döndür
            double kiraFiyati = katsayi * odaSayisi;
            return kiraFiyati;
        }

        // Log Kaydı Metodu
        private void LogKaydi(string mesaj)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + mesaj);
            }
        }

        // Dosyadan Kiralık Ev Oku Metodu
        public static List<KiralikEv> KiralikEvleriOku(string dosyaAdi)
        {
            List<KiralikEv> kiralikEvler = new List<KiralikEv>();

            if (File.Exists(dosyaAdi))
            {
                var satirlar = File.ReadAllLines(dosyaAdi);
                foreach (var satir in satirlar)
                {
                    var veriler = satir.Split(',');
                    KiralikEv ev = new KiralikEv(
                        int.Parse(veriler[0].Split(':')[1].Trim()),
                        int.Parse(veriler[1].Split(':')[1].Trim()),
                        veriler[2].Split(':')[1].Trim(),
                        double.Parse(veriler[3].Split(':')[1].Trim()),
                        DateTime.Parse(veriler[4].Split(':')[1].Trim()),
                        (EvTuru)Enum.Parse(typeof(EvTuru), veriler[5].Split(':')[1].Trim()),
                        bool.Parse(veriler[6].Split(':')[1].Trim()),
                        veriler[7].Split(':')[1].Trim(),
                        double.Parse(veriler[8].Split(':')[1].Trim()),
                        double.Parse(veriler[9].Split(':')[1].Trim())
                    );
                    kiralikEvler.Add(ev);
                }
            }
            return kiralikEvler;
        }




        // Dosyadan Satılık Ev Oku Metodu
        public static List<SatilikEv> SatilikEvleriOku(string dosyaAdi)
        {
            List<SatilikEv> satilikEvler = new List<SatilikEv>();

            if (File.Exists(dosyaAdi))
            {
                var satirlar = File.ReadAllLines(dosyaAdi);
                foreach (var satir in satirlar)
                {
                    var veriler = satir.Split(',');
                    SatilikEv ev = new SatilikEv(
                        int.Parse(veriler[0].Split(':')[1].Trim()),
                        int.Parse(veriler[1].Split(':')[1].Trim()),
                        veriler[2].Split(':')[1].Trim(),
                        double.Parse(veriler[3].Split(':')[1].Trim()),
                        DateTime.Parse(veriler[4].Split(':')[1].Trim()),
                        (EvTuru)Enum.Parse(typeof(EvTuru), veriler[5].Split(':')[1].Trim()),
                        bool.Parse(veriler[6].Split(':')[1].Trim()),
                        veriler[7].Split(':')[1].Trim(),
                        double.Parse(veriler[8].Split(':')[1].Trim())
                    );
                    satilikEvler.Add(ev);
                }
            }
            return satilikEvler;
        }
    }
}