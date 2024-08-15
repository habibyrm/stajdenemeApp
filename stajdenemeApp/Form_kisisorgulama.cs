using stajdenemeApp.ComplexModels;
using stajdenemeApp.Core;
using stajdenemeApp.Models;
using System.Data;

namespace stajdenemeApp
{
    public partial class Form_kisisorgulama : Form
    {
        public Form_kisisorgulama()
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
                }
                else
                {
                }
            }
            else
            {
            }
        }

        public void ClearTextboxs(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.HasChildren)
                {
                    ClearTextboxs(c);
                }
                else
                {
                    if (c is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextboxs(this);
        }

        private void Form_kisisorgulama_Load(object sender, EventArgs e)
        {

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
                }
                else
                {
                }
            }
            else
            {
            }
        }
    }
}
