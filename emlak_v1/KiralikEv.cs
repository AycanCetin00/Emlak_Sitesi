using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace emlak_v1
{
    public class KiralikEv : Ev
    {
        // Alanlar
        public double Depozito { get; set; }
        public double Kira { get; set; }

        // Kurucu Metot
        public KiralikEv(int odaSayisi, int katNumarasi, string semt, double alani, DateTime yapimTarihi, EvTuru tur, bool aktif, string emlakNumarasi, double depozito, double kira)
            : base(odaSayisi, katNumarasi, semt, alani, yapimTarihi, tur, aktif, emlakNumarasi)
        {
            Depozito = depozito;
            Kira = kira;
        }

        // Ev Bilgileri Metodu Override
        public override string EvBilgileri()
        {
            return base.EvBilgileri() + string.Format(", Depozito: {0}, Kira: {1}", Depozito, Kira);
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