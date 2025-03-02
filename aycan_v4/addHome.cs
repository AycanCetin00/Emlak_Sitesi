using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using emlak_v1;
namespace aycan_v4
{
    public partial class addHome : Form
    {
        public addHome()
        {
            InitializeComponent();
        }
        // Yeni ev ekleme yöntemi
        private void btnAddEv_Click(object sender, EventArgs e)
        {
            int odaSayisi = int.Parse(nmrOdaSayisi.Value.ToString());
            int katNumarasi = int.Parse(nmrKatNumarasi.Value.ToString());
            string semt = cmbSemt.Text.ToString();
            double alani = double.Parse(mttxtAlani.Text);
            DateTime yapimTarihi = txtYapimTarihi.Value;
            EvTuru tur = (EvTuru)Enum.Parse(typeof(EvTuru), cmbTur.SelectedItem.ToString());
            bool aktif = chkAktif.Checked;
            string emlakNumarasi = Guid.NewGuid().ToString();

            if (rbtnKiralik.Checked)
            {
                double depozito = double.Parse(txtDepozito.Text);
                double kira = double.Parse(txtKira.Text);

                // Kayıt kontrolü
                if (!EmlakKaydiMevcutMu("kiralik.txt", odaSayisi, katNumarasi, semt, alani, yapimTarihi, kira, depozito))
                {
                    var kiralikEv = new KiralikEv(odaSayisi, katNumarasi, semt, alani, yapimTarihi, tur, aktif, emlakNumarasi, depozito, kira);
                    kiralikEv.DosyayaYaz("kiralik.txt"); // Yeni kayıt olduğunda dosyaya yaz
                }
                else
                {
                    MessageBox.Show("Bu kiralık ev zaten kayıtlı.");
                    return; // Tekrar eklemeyi önlemek için metottan çık
                }
            }
            else if (rbtnSatilik.Checked)
            {
                double fiyat = double.Parse(txtFiyat.Text);

                // Kayıt kontrolü
                if (!EmlakKaydiMevcutMu("satilik.txt", odaSayisi, katNumarasi, semt, alani, yapimTarihi, fiyat))
                {
                    var satilikEv = new SatilikEv(odaSayisi, katNumarasi, semt, alani, yapimTarihi, tur, aktif, emlakNumarasi, fiyat);
                    satilikEv.DosyayaYaz("satilik.txt"); // Yeni kayıt olduğunda dosyaya yaz
                }
                else
                {
                    MessageBox.Show("Bu satılık ev zaten kayıtlı.");
                    return; // Tekrar eklemeyi önlemek için metottan çık
                }
            }
            else
            {
                MessageBox.Show("Lütfen ev türünü seçin (Kiralık veya Satılık).");
            }
            this.Hide();
        }

        private bool EmlakKaydiMevcutMu(string dosyaAdi, int odaSayisi, int katNumarasi, string semt, double alani, DateTime yapimTarihi, double fiyatVeyaKira, double depozito = 0)
        {
            if (File.Exists(dosyaAdi))
            {
                var satirlar = File.ReadAllLines(dosyaAdi);
                foreach (var satir in satirlar)
                {
                    var bilgiler = satir.Split(',');
                    if (int.Parse(bilgiler[0]) == odaSayisi &&
                        int.Parse(bilgiler[1]) == katNumarasi &&
                        bilgiler[2] == semt &&
                        double.Parse(bilgiler[3]) == alani &&
                        DateTime.Parse(bilgiler[4]) == yapimTarihi &&
                        double.Parse(bilgiler[5]) == fiyatVeyaKira &&
                        (dosyaAdi == "kiralik.txt" ? double.Parse(bilgiler[6]) == depozito : true))
                    {
                        return true; // Aynı kayıt zaten mevcut
                    }
                }
            }
            return false;
        }

        private List<string> DosyadanEmlakNumaralariOku(string dosyaAdi)
        {
            var emlakNumaralari = new List<string>();
            if (File.Exists(dosyaAdi))
            {
                var satirlar = File.ReadAllLines(dosyaAdi);
                foreach (var satir in satirlar)
                {
                    var emlakNumarasi = satir.Split(',')[0]; // Varsayalım ki emlak numarası ilk sütunda yer alıyor
                    emlakNumaralari.Add(emlakNumarasi);
                }
            }
            return emlakNumaralari;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addHome_Load(object sender, EventArgs e)
        {
            cmbTur.DataSource = Enum.GetValues(typeof(EvTuru));
            ComboBoxaSemtleriEkle("semtler.txt");
        }
        private void ComboBoxaSemtleriEkle(string dosyaYolu)
        {
            try
            {
                // Dosya varsa semtleri ComboBox'a ekle
                if (File.Exists(dosyaYolu))
                {
                    string[] semtler = File.ReadAllLines(dosyaYolu);
                    cmbSemt.Items.AddRange(semtler);
                }
                else
                {
                    MessageBox.Show("Semtler dosyası bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void rbtnKiralik_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKiralik.Checked)
            {
                txtDepozito.Enabled = true;
                txtKira.Enabled = true;
                txtFiyat.Enabled = false;
            }
            if (rbtnSatilik.Checked)
            {
                txtDepozito.Enabled = false;
                txtKira.Enabled = false;
                txtFiyat.Enabled = true;
            }
        }

        public void LoadEvBilgileri(string emlakNumarasi)
        {
            // Kiralık veya satılık dosyasını belirle
            string dosyaAdi = "kiralik.txt"; // Varsayılan; duruma göre satılık.txt'yi de kullanabilirsiniz.

            // Dosyadaki satırları oku ve eşleşen emlak numarasını bul
            if (File.Exists(dosyaAdi))
            {
                var satirlar = File.ReadAllLines(dosyaAdi);
                foreach (var satir in satirlar)
                {
                    var bilgiler = satir.Split(',');

                    // Emlak numarası eşleşiyorsa formu doldur
                    if (bilgiler[0] == emlakNumarasi) // Emlak numarasının ilk sütunda olduğunu varsayıyorum
                    {
                        nmrOdaSayisi.Value = int.Parse(bilgiler[1]);
                        nmrKatNumarasi.Value = int.Parse(bilgiler[2]);
                        cmbSemt.Text = bilgiler[3];
                        mttxtAlani.Text = bilgiler[4];
                        txtYapimTarihi.Value = DateTime.Parse(bilgiler[5]);
                        cmbTur.SelectedItem = (EvTuru)Enum.Parse(typeof(EvTuru), bilgiler[6]);
                        chkAktif.Checked = bool.Parse(bilgiler[7]);

                        // Kiralık ise depozito ve kira, satılık ise fiyat
                        if (dosyaAdi == "kiralik.txt")
                        {
                            rbtnKiralik.Checked = true;
                            txtDepozito.Text = bilgiler[8];
                            txtKira.Text = bilgiler[9];
                        }
                        else
                        {
                            rbtnSatilik.Checked = true;
                            txtFiyat.Text = bilgiler[8];
                        }

                        break; // İlgili kaydı bulunca döngüyü bitir
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt dosyası bulunamadı.");
            }
        }

        private void rbtnSatilik_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKiralik.Checked)
            {
                txtDepozito.Enabled = true;
                txtKira.Enabled = true;
                txtFiyat.Enabled = false;
            }
            if (rbtnSatilik.Checked)
            {
                txtDepozito.Enabled = false;
                txtKira.Enabled = false;
                txtFiyat.Enabled = true;
            }
        }
        // Fiyat Hesapla Metodu
        public double FiyatHesapla(int kira)
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
            double kiraFiyati = katsayi * kira;
            return kiraFiyati;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double kiraFiyati = FiyatHesapla(Convert.ToInt32(txtKira.Text)); // Oluşturulan nesne üzerinden FiyatHesapla metodunu çağır
            label13.Text = kiraFiyati.ToString();
           
  
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
