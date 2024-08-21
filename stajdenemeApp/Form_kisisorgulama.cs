using stajdenemeApp.ComplexModels;
using stajdenemeApp.Core;
using stajdenemeApp.Models;
using System.Data;
using System.Windows.Forms;

namespace stajdenemeApp
{
    public partial class Form_kisisorgulama : Form
    {
        public Form_kisisorgulama()
        {
            InitializeComponent();
        }

        public void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlara ve kontrol tuşlarına (örneğin Backspace) izin ver
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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


                    string annetc = kisi.AnneTc;
                    string babatc = kisi.BabaTc;

                    var anne = context.Kisi
                        .Where(k => k.Tc == annetc)
                        .Select(k => new
                        {
                            k.Ad
                        }).FirstOrDefault();

                    var baba = context.Kisi
                        .Where(k => k.Tc == babatc)
                        .Select(k => new
                        {
                            k.Ad
                        }).FirstOrDefault();
                    txtad.Text = kisi.Ad;
                    txtsoyad.Text = kisi.Soyad;
                    txtasn.Text = kisi.AileSiraNo.ToString();
                    txtbsn.Text = kisi.BireySiraNo.ToString();
                    txtannetc.Text = kisi.AnneTc;
                    txtbabatc.Text = kisi.BabaTc;
                    txtmedenihal.Text = kisi.MedeniHal_aciklamasi;
                    txtmedenihalkodu.Text = kisi.MedeniHal_kodu.ToString();
                    txtdurum.Text = kisi.Durum_aciklamasi;
                    txtdurumkodu.Text = kisi.Durum_kodu.ToString();
                    txtannead.Text = anne.Ad;
                    txtbabaad.Text = baba.Ad;
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
                return;
            }
            // Entity Framework DbContext'ini kullanarak veritabanı sorgusu
            Kisi_Bilgileri(tc);
            using (var context = new StajdenemeContext())
            {
                // TC numarasına ait olay geçmişi verilerini getirir
                var query = from olay in context.OlayGecmisi
                            where olay.KisiTc == tc
                            select new
                            {
                                olay.OlayKodu,
                                olay.KisiTc,
                                olay.EsTc,
                                olay.Zaman,
                                olay.KullaniciId
                            };

                // DataGridView'in datasource'unu getirilen verilere set eder
                dataGridViewolay.DataSource = query.ToList();

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int aileSiraNo = int.Parse(txtasn.Text);
            int bireySiraNo = int.Parse(txtbsn.Text) + 1;

            using var context = new StajdenemeContext();
            var entAile = context.Aile.FirstOrDefault(x => x.AileSiraNo == aileSiraNo && x.BireySiraNo == bireySiraNo);
            if (entAile != null)
            {
                var entKisi = context.Kisi.FirstOrDefault(x => x.AileKodu == entAile.IdAile);
                if (entKisi != null)
                {
                    txtTC.Text = entKisi.Tc;
                    Kisi_Bilgileri(entKisi.Tc);
                    // TC numarasına ait olay geçmişi verilerini getirir
                    var query = from olay in context.OlayGecmisi
                                where olay.KisiTc == entKisi.Tc
                                select new
                                {
                                    olay.OlayKodu,
                                    olay.KisiTc,
                                    olay.EsTc,
                                    olay.Zaman,
                                    olay.KullaniciId
                                };

                    // DataGridView'in datasource'unu getirilen verilere set eder
                    dataGridViewolay.DataSource = query.ToList();
                }
            }
        }
        private void btnonceki_Click(object sender, EventArgs e)
        {
            int aileSiraNo = int.Parse(txtasn.Text);
            int bireySiraNo = int.Parse(txtbsn.Text) - 1;

            using var context = new StajdenemeContext();
            var entAile = context.Aile.FirstOrDefault(x => x.AileSiraNo == aileSiraNo && x.BireySiraNo == bireySiraNo);
            if (entAile != null)
            {
                var entKisi = context.Kisi.FirstOrDefault(x => x.AileKodu == entAile.IdAile);
                if (entKisi != null)
                {
                    txtTC.Text = entKisi.Tc;
                    Kisi_Bilgileri(entKisi.Tc);
                    // TC numarasına ait olay geçmişi verilerini getirir
                    var query = from olay in context.OlayGecmisi
                                where olay.KisiTc == entKisi.Tc
                                select new
                                {
                                    olay.OlayKodu,
                                    olay.KisiTc,
                                    olay.EsTc,
                                    olay.Zaman,
                                    olay.KullaniciId
                                };

                    // DataGridView'in datasource'unu getirilen verilere set eder
                    dataGridViewolay.DataSource = query.ToList();
                }
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            FormHelper.Clear_Textboxs(this);
            dataGridViewolay.DataSource = null;
        }
    }
}
