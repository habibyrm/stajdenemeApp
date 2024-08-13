using Microsoft.EntityFrameworkCore;
using stajdenemeApp.ComplexModels;
using stajdenemeApp.Models;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Xml.Linq;
//using System.Xml;

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

        public void TcKontrol(string tc)
        {
            if (tc.Length != 11)
            {
                MessageBox.Show("Lütfen 11 haneli geçerli bir TC kimlik numarası girin\t" + tc, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Eş Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            using (var context = new StajdenemeContext())
            {
                try
                {
                    var kisi = FormHelper.KisiBilgileriGetir(tc);
                    es_tc = kisi.EsTc;
                    cilt_kodu = kisi.cilt_kodu;
                    var es = FormHelper.EsBilgileriGetir(es_tc);
                    if (es == null)
                    {
                        MessageBox.Show("Eş Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            KisiBilgileri kisi=FormHelper.KisiBilgileriGetir(tc);
            es_tc = kisi.EsTc;
            cilt_kodu = kisi.cilt_kodu;
            cilt_kodu = kisi.cilt_kodu;
            txtannead.Text = kisi.Ad;
            txtannetc.Text = tc;
            txtsoyad.Text = kisi.Soyad;
            txtanneasn.Text = kisi.AileSiraNo.ToString();
            txtannebsn.Text = kisi.BireySiraNo.ToString();
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
                MessageBox.Show("En az bir kişinin kimlik no ihtiyaç duyulmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            FormHelper.Clear_Textboxs(this);
        }

        private void btndogur_Click(object sender, EventArgs e)
        {
            FormHelper.Dogum_Kontrol(grup_cocuk);
            if (!string.IsNullOrEmpty(txtcocukad.Text))
            {
                string tc = TC.GenerateRandomTC();
                txtcocuktc.Text = tc;
            }
            else
                return;
            int cinsiyet = FormHelper.Cinsiyet_Kontrol(comboBoxcinsiyet.Text);
            int sehir = FormHelper.Sehir_Kontrol(comboBoxsehir.Text);
            try {
                using (var context = new StajdenemeContext())
                {
                    var aile = new Aile
                    {
                        AileSiraNo = Int32.Parse(txtanneasn.Text),
                        BireySiraNo = Int32.Parse(txtbababsn.Text) + 1,
                        AnneTc = txtannetc.Text,
                        BabaTc = txtbabatc.Text,
                        //CiltKodu=
                    };
                    var kisi = new Kisi
                    {
                        Tc = txtcocuktc.Text,
                        Ad = txtcocukad.Text,
                        Soyad = txtsoyad.Text,
                        DurumKodu = 1,
                        MedeniHalKodu = 1,
                        CinsiyetKodu = cinsiyet,
                        DogumYeriKodu = sehir
                        //ailekodu
                    };

                    context.Kisi.Add(kisi);
                    context.SaveChanges();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Veritabanına veri eklenirken hata oluştu.{ex.Message}","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            MessageBox.Show("Veri başarıyla eklendi!");
        }
    }
}
