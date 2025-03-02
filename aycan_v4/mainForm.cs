using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using emlak_v1;
using System.IO;
namespace aycan_v4
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private List<Emlak> emlakListesi = new List<Emlak>();


        // Kiralık evleri yükleyen yöntem

        // private List<KiralikEv> yüklüKiralikEvler = new List<KiralikEv>();
        // private List<SatilikEv> yüklüSatilikEvler = new List<SatilikEv>();
        private void btnLoadKiralik_Click(object sender, EventArgs e)
        {
            // Önce DataGridView temizle
          //  dataGridView1.DataSource = null;
            //dataGridView1.Rows.Clear();

            var kiralikEvler = Ev.KiralikEvleriOku("kiralik.txt");
            dataGridView1.DataSource = kiralikEvler.Select(ev => new
            {
                ev.OdaSayisi,
                ev.KatNumarasi,
                ev.Semt,
                ev.Alani,
                YapimTarihi = ev.YapimTarihi.ToShortDateString(),
                ev.Tur,
                ev.Aktif,
                ev.EmlakNumarasi,
                Depozito = ((KiralikEv)ev).Depozito,
                Kira = ((KiralikEv)ev).Kira
            }).ToList();
        }

        // Satılık evleri yükleyen yöntem
        private void btnLoadSatilik_Click(object sender, EventArgs e)
        {
            // Önce DataGridView temizle
            //dataGridView1.DataSource = null;
            //dataGridView1.Rows.Clear();

            var satilikEvler = Ev.SatilikEvleriOku("satilik.txt");
            dataGridView1.DataSource = satilikEvler.Select(ev => new
            {
                ev.OdaSayisi,
                ev.KatNumarasi,
                ev.Semt,
                ev.Alani,
                YapimTarihi = ev.YapimTarihi.ToShortDateString(),
                ev.Tur,
                ev.Aktif,
                ev.EmlakNumarasi,
                Fiyat = ((SatilikEv)ev).Fiyat
            }).ToList();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string emlakNumarasi = selectedRow.Cells["EmlakNumarasi"].Value.ToString();

                // Dosyadan ilgili kaydı sil
                string dosyaAdi = selectedRow.Cells["Tur"].Value.ToString() == "Kiralık" ? "kiralik.txt" : "satilik.txt";
                var satirlar = File.ReadAllLines(dosyaAdi).Where(line => !line.Contains(emlakNumarasi)).ToList();
                File.WriteAllLines(dosyaAdi, satirlar);

                // DataGridView'i yeniden yükle
                if (dosyaAdi == "kiralik.txt")
                {
                    btnLoadKiralik_Click(sender, e); // Kiralık evleri yeniden yükle
                }
                else
                {
                    btnLoadSatilik_Click(sender, e); // Satılık evleri yeniden yükle
                }

                MessageBox.Show("Kayıt başarıyla silindi!");
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçin.");
            }
        }

        private void addHome_Click(object sender, EventArgs e)
        {
            addHome frm = new addHome();
            frm.ShowDialog();
        }

        
        private void duzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string emlakNumarasi = selectedRow.Cells["EmlakNumarasi"].Value.ToString();

                // Düzenleme formunu oluştur ve mevcut verileri aktar
                addHome frm = new addHome();
                frm.LoadEvBilgileri(emlakNumarasi); // Veriyi yükle
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Düzenlenen kaydı güncellemek için kodları ekleyin
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kaydı seçin.");
            }
        }
    }
}