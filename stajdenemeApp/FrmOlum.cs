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
        DateTime zaman;
        private void buttonValidate_Click(object sender, EventArgs e)
        {
            int day, month, year, hour, minute;

            // Gün değerinin geçerli bir sayı olup olmadığını kontrol et.
            if (!int.TryParse(txtgun.Text, out day) || day < 1 || day > 31)
            {
                MessageBoxHelper.ShowMessageBoxWarning("Geçerli bir gün değeri girin (1-31).");
                return;
            }

            // Ay değerinin geçerli bir sayı olup olmadığını kontrol et.
            if (!int.TryParse(txtay.Text, out month) || month < 1 || month > 12)
            {
                MessageBoxHelper.ShowMessageBoxWarning("Geçerli bir ay değeri girin (1-12).");
                return;
            }

            // Yıl değerinin geçerli bir sayı olup olmadığını kontrol et.
            if (!int.TryParse(txtyil.Text, out year) || year < 1)
            {
                MessageBoxHelper.ShowMessageBoxWarning("Geçerli bir yıl değeri girin.");
                return;
            }

            // Saat değerinin geçerli bir sayı olup olmadığını kontrol et.
            if (!int.TryParse(txtsaat.Text, out hour) || hour < 0 || hour > 23)
            {
                MessageBoxHelper.ShowMessageBoxWarning("Geçerli bir saat değeri girin (0-23).");
                return;
            }

            // Dakika değerinin geçerli bir sayı olup olmadığını kontrol et.
            if (!int.TryParse(txtdakika.Text, out minute) || minute < 0 || minute > 59)
            {
                MessageBox.Show("Geçerli bir dakika değeri girin (0-59).");
                return;
            }

            // Geçerli bir tarih ve saat olup olmadığını kontrol et.
            try
            {
                DateTime dateTime = new DateTime(year, month, day, hour, minute, 0);
                zaman = dateTime;

                // Gelecek bir tarih olup olmadığını kontrol et.
                if (dateTime > DateTime.Now)
                {
                    MessageBoxHelper.ShowMessageBoxWarning("Gelecek tarihler kabul edilemez. Lütfen bugünün tarihi veya daha önceki bir tarihi girin.");
                    return;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBoxHelper.ShowMessageBoxWarning("Girilen değerler geçerli bir tarih ve saat oluşturmuyor.");
            }
        }

        public void Kisi_Bilgileri(string tc)
        {
            using (var context = new DbContextSingelton().Instance)
            {
                try
                {
                    var kisi = FormHelper.KisiBilgileriGetir(tc);

                    if (kisi == null)
                    {
                        MessageBoxHelper.ShowMessageBoxError("Kişi Bulunamadı");
                        MessageBox.Show("Kişi Bulunamadı", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSorgula_Click(object sender, EventArgs e)
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
            buttonValidate_Click(sender, e);
            string tcKimlikNo = txtTC.Text;
            using (var context = new DbContextSingelton().Instance)
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
                        FormHelper.Clear_Textboxs(this);
                        OlayKayit kayit = new OlayKayit();
                        kayit.OlayKaydi(tcKimlikNo, zaman, 2);
                    }
                }
                else
                {
                    MessageBoxHelper.ShowMessageBoxError("Kayıt bulunamadı.");
                    FormHelper.Clear_Textboxs(this);
                }
            }
        }
    }
}
