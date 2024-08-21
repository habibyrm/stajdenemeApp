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
    public partial class FormEvlenme : Form
    {
        public FormEvlenme()
        {
            InitializeComponent();
        }

        KisiBilgileri kisi1;
        KisiBilgileri kisi2;
        DateTime zaman;
        public void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlara ve kontrol tuşlarına (örneğin Backspace) izin ver
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
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
        public bool EkranKontrol()
        {
            if (string.IsNullOrEmpty(txtTC1.Text) || string.IsNullOrEmpty(txtTC2.Text))
            {
                MessageBoxHelper.ShowMessageBoxError("Lütfen her 2 kişinin de T.C. verilerini girinin!");
                return false;
            }
            else if (kisi1.cinsiyet_kodu == kisi2.cinsiyet_kodu)
            {
                MessageBoxHelper.ShowMessageBoxError("Aynı cinsiyetteki kişiler evlnemez.");
                return false;
            }
            else if (18 > FormHelper.YasHesaplama(FormHelper.Dogumtarihi(kisi1.Tc)) || 18 > FormHelper.YasHesaplama(FormHelper.Dogumtarihi(kisi2.Tc)))
            {
                MessageBoxHelper.ShowMessageBoxError("18 yaşından küçük kişiler evlenemez.");
                return false;
            }
            else if (kisi1.MedeniHal_kodu != 1 || kisi2.MedeniHal_kodu != 1)
            {
                MessageBoxHelper.ShowMessageBoxError("Evli kişiler evlenemez.");
                return false;
            }
            else if (kisi1.Durum_kodu == 3 || kisi2.Durum_kodu == 3)
            {
                MessageBoxHelper.ShowMessageBoxError("Ölü kişiler evlenemez.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnkisi1_Click(object sender, EventArgs e)
        {
            string tc = txtTC1.Text;
            using (var context = new DbContextSingelton().Instance)
            {
                try
                {
                    kisi1 = FormHelper.KisiBilgileriGetir(tc);

                    if (kisi1 == null)
                    {
                        MessageBoxHelper.ShowMessageBoxError("Kişi Bulunamadı");
                        return;
                    }
                    txtad1.Text = kisi1.Ad;
                    txtsoyad1.Text = kisi1.Soyad;
                    txtasn1.Text = kisi1.AileSiraNo.ToString();
                    txtbsn1.Text = kisi1.BireySiraNo.ToString();
                    txtmedenihal1.Text = kisi1.MedeniHal_aciklamasi;
                    txtmedenihalkodu1.Text = kisi1.MedeniHal_kodu.ToString();
                    txtdurum1.Text = kisi1.Durum_aciklamasi;
                    txtdurumkodu1.Text = kisi1.Durum_kodu.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"veritabanından bilgi çekerken bir hata oluştu {ex.Message}");
                }
            }
        }
        private void btnkisi2_Click(object sender, EventArgs e)
        {
            string tc = txtTC2.Text;
            using (var context = new DbContextSingelton().Instance)
            {
                try
                {
                    kisi2 = FormHelper.KisiBilgileriGetir(tc);

                    if (kisi2 == null)
                    {
                        MessageBoxHelper.ShowMessageBoxError("Kişi Bulunamadı");
                        return;
                    }
                    txtad2.Text = kisi2.Ad;
                    txtsoyad2.Text = kisi2.Soyad;
                    txtasn2.Text = kisi2.AileSiraNo.ToString();
                    txtbsn2.Text = kisi2.BireySiraNo.ToString();
                    txtmedenihal2.Text = kisi2.MedeniHal_aciklamasi;
                    txtmedenihalkodu2.Text = kisi2.MedeniHal_kodu.ToString();
                    txtdurum2.Text = kisi2.Durum_aciklamasi;
                    txtdurumkodu2.Text = kisi2.Durum_kodu.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"veritabanından bilgi çekerken bir hata oluştu {ex.Message}");
                }
            }
        }

        private void btnevlenme_Click(object sender, EventArgs e)
        {
            buttonValidate_Click(sender, e);
            EkranKontrol();
            int? maxAileSiraNo;
            int ciltkodu = FormHelper.Cilt_Kontrol(comboBoxcilt.Text);
            try
            {
                using (var context = new DbContextSingelton().Instance)
                {
                    var kisi1 = context.Kisi.SingleOrDefault(k => k.Tc == txtTC1.Text);
                    var kisi2 = context.Kisi.SingleOrDefault(k => k.Tc == txtTC2.Text);
                    var aile1 = context.Aile.SingleOrDefault(a => a.IdAile == kisi1.AileKodu);
                    var aile2 = context.Aile.SingleOrDefault(a => a.IdAile == kisi2.AileKodu);
                    if (kisi1 == null)
                    {
                        throw new Exception($"Kişi bulunamadı: {txtTC1.Text}");
                    }

                    if (kisi2 == null)
                    {
                        throw new Exception($"Kişi bulunamadı: {txtTC2.Text}");
                    }
                    maxAileSiraNo = context.Aile
                    .Max(a => (int?)a.AileSiraNo);
                    maxAileSiraNo += 1;
                    aile1.AileSiraNo = maxAileSiraNo.Value;
                    aile1.BireySiraNo = 1;
                    kisi1.MedeniHalKodu = 2;
                    aile1.EsTc = kisi2.Tc;
                    aile2.AileSiraNo = maxAileSiraNo.Value;
                    aile2.BireySiraNo = 2;
                    kisi2.MedeniHalKodu = 2;
                    aile2.EsTc = kisi1.Tc;
                    context.SaveChanges();
                    OlayKayit kayit = new OlayKayit();
                    kayit.OlayKaydi(txtTC1.Text, txtTC2.Text, zaman, 3);
                    kayit.OlayKaydi(txtTC2.Text, txtTC1.Text, zaman, 3);
                    MessageBox.Show("İşlem başarıyla gerçekleştirildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu! {ex}");
            }
        }
    }
}
