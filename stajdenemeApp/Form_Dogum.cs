using Microsoft.EntityFrameworkCore;
using stajdenemeApp.ComplexModels;
using stajdenemeApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using stajdenemeApp.Models;

namespace stajdenemeApp
{
    public partial class Form_Dogum : Form
    {
        public Form_Dogum()
        {
            InitializeComponent();
        }

        int cilt_kodu = 0;
        string es_tc;
        DateTime zaman;

        public void TcKontrol(string tc)
        {
            if (tc.Length != 11)
            {
                MessageBoxHelper.ShowMessageBoxError("Lütfen 11 haneli geçerli bir TC kimlik numarası girin\t" + tc);
                return;
            }
        }
        public void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlara ve kontrol tuşlarına (örneğin Backspace) izin ver
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void txtTC_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 11)
            {
                // 11 karakteri aşarsa, fazla kısmı kes
                textBox.Text = textBox.Text.Substring(0, 11);
                // İmleci en sona yerleştir
                textBox.SelectionStart = textBox.Text.Length;
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
                if (7 < FormHelper.YasHesaplama(dateTime))
                {
                    MessageBoxHelper.ShowMessageBoxWarning("Doğan çocuğun yaşı 7 den küçük olmalıdır!");
                    return;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBoxHelper.ShowMessageBoxWarning("Girilen değerler geçerli bir tarih ve saat oluşturmuyor.");
            }
        }


        public void Kisi_Bilgiler_Anne(string tc)
        {
            {
                try
                {
                    var kisi = FormHelper.KisiBilgileriGetir(tc);
                    es_tc = kisi.EsTc;
                    cilt_kodu = kisi.cilt_kodu;
                    var es = FormHelper.EsBilgileriGetir(es_tc);
                    if (es == null)
                    {
                        MessageBoxHelper.ShowMessageBoxError("Eş Bulunamadı");
                        return;
                    }
                    txtannead.Text = kisi.Ad;
                    txtannetc.Text = tc;
                    txtsoyad.Text = kisi.Soyad;
                    txtanneasn.Text = kisi.AileSiraNo.ToString();
                    txtannebsn.Text = kisi.BireySiraNo.ToString();
                    txtbabad.Text = es.Ad;
                    txtbabasn.Text = es.AileSiraNo.ToString();
                    txtbababsn.Text = es.BireySiraNo.ToString();
                    txtbabatc.Text = es_tc;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"veritabanından bilgi çekerken bir hata oluştu {ex.Message}");
                }
            }
        }

        public void Kisi_Bilgiler_Baba(string tc)
        {
            using (var context = new DbContextSingelton().Instance)
            {
                try
                {
                    var kisi = FormHelper.KisiBilgileriGetir(tc);
                    es_tc = kisi.EsTc;
                    cilt_kodu = kisi.cilt_kodu;
                    var es = FormHelper.EsBilgileriGetir(es_tc);
                    if (es == null)
                    {
                        MessageBoxHelper.ShowMessageBoxError("Eş Bulunamadı");
                        return;
                    }

                    txtbabad.Text = kisi.Ad;
                    txtbabatc.Text = tc;
                    txtsoyad.Text = kisi.Soyad;
                    txtbabasn.Text = kisi.AileSiraNo.ToString();
                    txtbababsn.Text = kisi.BireySiraNo.ToString();
                    txtannead.Text = es.Ad;
                    txtanneasn.Text = es.AileSiraNo.ToString();
                    txtannebsn.Text = es.BireySiraNo.ToString();
                    txtannetc.Text = es_tc;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"veritabanından bilgi çekerken bir hata oluştu {ex.Message}");
                }
            }
        }

        private void btnannesorgula_Click(object sender, EventArgs e)
        {

            string tc = txtannetc.Text;
            TcKontrol(tc);
            KisiBilgileri kisi = FormHelper.KisiBilgileriGetir(tc);
            es_tc = kisi.EsTc;
            cilt_kodu = kisi.cilt_kodu;
            cilt_kodu = kisi.cilt_kodu;
            txtannead.Text = kisi.Ad;
            txtannetc.Text = tc;
            txtsoyad.Text = kisi.Soyad;
            txtanneasn.Text = kisi.AileSiraNo.ToString();
            txtannebsn.Text = kisi.BireySiraNo.ToString();
            cilt_kodu = kisi.cilt_kodu;
        }

        private void btnbabasorgula_Click(object sender, EventArgs e)
        {
            string tc = txtbabatc.Text;
            KisiBilgileri kisi = FormHelper.KisiBilgileriGetir(tc);
            es_tc = kisi.EsTc;
            txtbabad.Text = kisi.Ad;
            txtbabatc.Text = tc;
            txtsoyad.Text = kisi.Soyad;
            txtbabasn.Text = kisi.AileSiraNo.ToString();
            txtbababsn.Text = kisi.BireySiraNo.ToString();
            cilt_kodu = kisi.cilt_kodu;
        }

        private void btnes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtannetc.Text))
            {
                string tc = txtannetc.Text;
                // TC kimlik numarasının 11 haneli olduğundan emin olun
                TcKontrol(tc);
                Kisi_Bilgiler_Anne(tc);
            }
            else if (!string.IsNullOrEmpty(txtbabatc.Text))
            {
                string tc = txtbabatc.Text;
                // TC kimlik numarasının 11 haneli olduğundan emin olun
                TcKontrol(tc);
                Kisi_Bilgiler_Baba(tc);
            }
            else
            {
                MessageBoxHelper.ShowMessageBoxError("En az bir kişinin kimlik no ihtiyaç duyulmaktadır.");
            }

        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            FormHelper.Clear_Textboxs(this);
        }

        private void btndogur_Click(object sender, EventArgs e)
        {
            buttonValidate_Click(sender, e);
            FormHelper.Dogum_Kontrol(grup_cocuk);
            if (!string.IsNullOrEmpty(txtcocukad.Text))
            {
                string tc = TC.GenerateRandomTC();
                txtcocuktc.Text = tc;
            }
            else
            { return; }
            int cinsiyet = FormHelper.Cinsiyet_Kontrol(comboBoxcinsiyet.Text);
            int sehir = FormHelper.Sehir_Kontrol(comboBoxsehir.Text);
            try
            {
                using (var context = new DbContextSingelton().Instance)
                {
                    int? maxBireySiraNo = context.Aile
                    .Where(a => a.AileSiraNo == Int32.Parse(txtanneasn.Text))
                    .Max(a => (int?)a.BireySiraNo);

                    // Yeni birey_sira_no en yüksek değerden 1 fazla olmalıdır.
                    int yeniBireySiraNo = (maxBireySiraNo ?? 0) + 1;

                    var aile = new Aile
                    {
                        AileSiraNo = Int32.Parse(txtanneasn.Text),
                        BireySiraNo = yeniBireySiraNo,
                        AnneTc = txtannetc.Text,
                        BabaTc = txtbabatc.Text,
                        CiltKodu = cilt_kodu
                    };
                    context.Aile.Add(aile);
                    context.SaveChanges();
                    int aileSiraNo = Int32.Parse(txtanneasn.Text);
                    int ailekodu = 0;
                    var yeniksi = context.Aile.FirstOrDefault(x => x.AileSiraNo == aileSiraNo && x.BireySiraNo == yeniBireySiraNo);
                    if(yeniksi != null) 
                    {
                        ailekodu = yeniksi.IdAile;
                    }
                    var kisi = new Kisi
                    {
                        Tc = txtcocuktc.Text,
                        Ad = txtcocukad.Text,
                        Soyad = txtsoyad.Text,
                        DurumKodu = 1,
                        MedeniHalKodu = 1,
                        CinsiyetKodu = cinsiyet,
                        DogumYeriKodu = sehir,
                        AileKodu = ailekodu
                    };

                    context.Kisi.Add(kisi);
                    context.SaveChanges();
                }
                OlayKayit kayit = new OlayKayit();
                kayit.OlayKaydi(txtcocuktc.Text, zaman, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanına veri eklenirken hata oluştu.{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Veri başarıyla eklendi!");
        }
    }
}

