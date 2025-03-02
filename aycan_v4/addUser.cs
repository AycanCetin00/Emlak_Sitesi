using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace aycan_v4
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }
        static void KullaniciEkle(string dosyaYolu, string kullaniciAdi, string sifre)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(dosyaYolu))
                {
                    sw.WriteLine(kullaniciAdi + "," + sifre);
                }
                Console.WriteLine("Kullanıcı başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        static void KullaniciSil(string dosyaYolu, string kullaniciAdi)
        {
            try
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);
                using (StreamWriter sw = new StreamWriter(dosyaYolu))
                {
                    foreach (string satir in satirlar)
                    {
                        string[] veriler = satir.Split(',');
                        if (veriler.Length >= 2 && veriler[0].Trim() != kullaniciAdi)
                        {
                            sw.WriteLine(satir);
                        }
                    }
                }
                Console.WriteLine("Kullanıcı başarıyla silindi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            KullaniciEkle("users.txt",txtUsername.Text, txtPassword.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciSil("users.txt", txtUsername.Text);

        }
    }
}