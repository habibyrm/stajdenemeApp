using Microsoft.EntityFrameworkCore;
using stajdenemeApp.Models;

namespace stajdenemeApp.ComplexModels
{
    public static class FormHelper
    {
        public static bool IsTextBoxeFilled(Control control)
        {
            if (control is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false; // Eğer bir TextBox boşsa, false döndür
                }
            }
            return true; // Tüm TextBox'lar doluysa, true döndür
        }

        public static void Clear_Textboxs(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.HasChildren)
                {
                    Clear_Textboxs(c);
                }
                else
                {
                    if (c is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                    else if (c is ComboBox comboBox)
                    {
                        comboBox.Text = string.Empty;
                    }
                }
            }
        }

        public static void Dogum_Kontrol(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox textbox)
                {
                    if (string.IsNullOrEmpty(textbox.Text))
                    {
                        MessageBox.Show("Boş alan bırakılmamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Clear_Textboxs(control);
                        return;
                    }
                }
                else if (c is ComboBox combobox)
                {
                    if (string.IsNullOrEmpty(combobox.Text))
                    {
                        MessageBox.Show("Boş alan bırakılmamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Clear_Textboxs(control);
                        return;
                    }
                }

            }

        }

        public static int Cinsiyet_Kontrol(string cinsiyet)
        {
            if (cinsiyet == "1-Erkek")
            {
                return 1;
            }
            else if (cinsiyet == "2-Kadın")
            {
                return 2;
            }
            return 0;

        }

        public static int Sehir_Kontrol(string sehir)
        {
            if (sehir == "İstanbul")
            {
                return 1;
            }
            else if (sehir == "Ankara")
            {
                return 2;
            }
            else if (sehir == "Tokat")
            {
                return 3;
            }
            else if (sehir == "Sakarya")
            {
                return 4;
            }
            return 0;

        }
        public static KisiBilgileri KisiBilgileriGetir(string tc)
        {
            using (var context = new StajdenemeContext())
            {
                return context.Kisi
                        .Include(k => k.Aile)
                        .Include(k => k.Medenihal)
                        .Include(k => k.Durum)
                        .Where(k => k.Tc == tc)
                        .Select(k => new KisiBilgileri
                        {
                            Ad = k.Ad,
                            Soyad = k.Soyad,
                            AileSiraNo = k.Aile.AileSiraNo.Value,
                            BireySiraNo = k.Aile.BireySiraNo.Value,
                            EsTc = k.Aile.EsTc,
                            cilt_kodu=k.Aile.CiltKodu,
                            AnneTc = k.Aile.AnneTc,
                            BabaTc = k.Aile.BabaTc,
                            MedeniHal_kodu=k.MedeniHalKodu.Value,
                            MedeniHal_aciklamasi = k.Medenihal.Aciklamasi,
                            Durum_aciklamasi = k.Durum.Aciklamasi,
                            Durum_kodu=k.DurumKodu.Value
                        }).FirstOrDefault();
            }
        }

        public static KisiBilgileri EsBilgileriGetir(string tc)
        {
            using (var context = new StajdenemeContext())
            {
                return context.Kisi
                        .Include(k => k.Aile)
                        .Where(k => k.Tc == tc)
                        .Select(k => new KisiBilgileri
                        {
                            Ad = k.Ad,
                            AileSiraNo = k.Aile.AileSiraNo.Value,
                            BireySiraNo = k.Aile.BireySiraNo.Value
                        }).FirstOrDefault();
            }
        }
    }
}