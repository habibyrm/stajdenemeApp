using Microsoft.EntityFrameworkCore;
using stajdenemeApp.ComplexModels;
using stajdenemeApp.Core;
using stajdenemeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stajdenemeApp
{
    public partial class FrmOlum : Form
    {
        public FrmOlum()
        {
            InitializeComponent();
        }

        public void Kisi_Bilgileri(string tc)
        {
            using (var context = new StajdenemeContext())
            {
                try
                {
                    var kisi = FormHelper.KisiBilgileriGetir(tc);

                    if (kisi == null)
                    {
                        MessageBoxHelper.ShowMessageBoxError("Kişi Bulunamadı");
                        return;
                    }
                    txtad.Text = kisi.Ad;
                    txtsoyad.Text = kisi.Soyad;
                    txtasn.Text = kisi.AileSiraNo.ToString();
                    txtbsn.Text = kisi.BireySiraNo.ToString();
                    txtmedenihal.Text = kisi.MedeniHal_aciklamasi;
                    txtmedenihalkodu.Text = kisi.MedeniHal_kodu.ToString();
                    txtdurum.Text = kisi.Durum_aciklamasi;
                    txtdurumkodu.Text = kisi.Durum_kodu.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"veritabanından bilgi çekerken bir hata oluştu {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text;

            // TC kimlik numarasının 11 haneli olduğundan emin olun
            if (tc.Length != 11 || !tc.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen 11 haneli geçerli bir TC kimlik numarası girin.");
                return;
            }
            // Entity Framework DbContext'ini kullanarak veritabanı sorgusu
            Kisi_Bilgileri(tc);
        }

        private void btnolum_Click(object sender, EventArgs e)
        {
            string tcKimlikNo=txtTC.Text;
            using (var context = new StajdenemeContext())
            {
                // TC kimlik numarasına göre kaydı bul
                var kisi = context.Kisi.SingleOrDefault(k => k.Tc == tcKimlikNo);

                if (kisi != null)
                {
                    if (kisi.DurumKodu == 3)
                    {
                        MessageBoxHelper.ShowMessageBoxError("Bu kişi zaten ölüdür.");
                    }
                    else
                    {
                        kisi.DurumKodu = 3;
                        context.SaveChanges();
                        MessageBox.Show("İşlem başarıyla gerçekleştirilmiştir.");
                        FormHelper.Clear_Textboxs(grupkisiolum);
                    }
                }
                else
                {
                    MessageBoxHelper.ShowMessageBoxError("Kayıt bulunamadı.");
                    FormHelper.Clear_Textboxs(grupkisiolum);
                }
            }
        }
    }
}
