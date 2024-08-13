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

        public bool EkranKontrol()
        {
            if (!string.IsNullOrEmpty(txtTC1.Text) || !string.IsNullOrEmpty(txtTC2.Text))
            {
                MessageBoxHelper.ShowMessageBoxError("Lütfen her 2 kişinin de T.C. verilerini girinin!");
                return false;
            }
            else if (kisi1.cinsiyet_kodu == kisi2.cinsiyet_kodu)
            {
                MessageBoxHelper.ShowMessageBoxError("Aynı cinsiyetteki kişiler evlnemez.");
                return false;
            }
            else if (18 > FormHelper.YasHesaplama(kisi1.Tc) || 18 > FormHelper.YasHesaplama(kisi2.Tc))
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
            using (var context = new StajdenemeContext())
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
            using (var context = new StajdenemeContext())
            {
                try
                {
                    kisi2 = FormHelper.KisiBilgileriGetir(tc);

                    if (kisi2 == null)
                    {
                        MessageBox.Show("Kişi Bulunamadı", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            EkranKontrol();
        }
    }
}
