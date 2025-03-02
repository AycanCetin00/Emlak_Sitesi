using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace emlak_v1
{
    public class SatilikEv : Ev
    {
        // Alanlar
        public double Fiyat { get; set; }

        // Kurucu Metot
        public SatilikEv(int odaSayisi, int katNumarasi, string semt, double alani, DateTime yapimTarihi, EvTuru tur, bool aktif, string emlakNumarasi, double fiyat)
            : base(odaSayisi, katNumarasi, semt, alani, yapimTarihi, tur, aktif, emlakNumarasi)
        {
            Fiyat = fiyat;
        }

        // Ev Bilgileri Metodu Override
        public override string EvBilgileri()
        {
            return base.EvBilgileri() + string.Format(", Fiyat: {0}", Fiyat);
        }

        // Dosyaya Yazma Metodu
        public void DosyayaYaz(string dosyaAdi)
        {
            using (StreamWriter writer = File.AppendText(dosyaAdi))
            {
                writer.WriteLine(EvBilgileri());
            }
        }
    }
}