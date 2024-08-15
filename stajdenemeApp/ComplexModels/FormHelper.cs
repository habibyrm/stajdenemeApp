using Microsoft.EntityFrameworkCore;
using stajdenemeApp.Core;
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
                        MessageBoxHelper.ShowMessageBoxError("Boş alan bırakılmamalıdır.");
                        Clear_Textboxs(control);
                        return;
                    }
                }
                else if (c is ComboBox combobox)
                {
                    if (string.IsNullOrEmpty(combobox.Text))
                    {
                        MessageBoxHelper.ShowMessageBoxError("Boş alan bırakılmamalıdır.");
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
        public static int YasHesaplama(DateTime? v)
        {
            DateTime tarih = v.Value.Date;
            DateTime today = DateTime.Today;
            int yas = today.Year - tarih.Year;

            //Eğer doğum günü bu yıl henüz gelmediyse, yaşı bir azalt.
            if (tarih > today.AddYears(-yas))
            {
                yas--;
            }

            return yas;
        }
        public static KisiBilgileri KisiBilgileriGetir(string tc)
        {
            var context = new DbContextSingelton().Instance;
            
                return context.Kisi
                        .Include(k => k.Aile)
                        .Include(k => k.MedeniHal)
                        .Include(k => k.Durum)
                        .Include(k => k.OlayGecmisi)
                        .Where(k => k.Tc == tc)
                        .Select(k => new KisiBilgileri
                        {
                            Ad = k.Ad,
                            Soyad = k.Soyad,
                            AileSiraNo = k.Aile.AileSiraNo.Value,
                            BireySiraNo = k.Aile.BireySiraNo.Value,
                            EsTc = k.Aile.EsTc,
                            cilt_kodu = k.Aile.CiltKodu,
                            AnneTc = k.Aile.AnneTc,
                            BabaTc = k.Aile.BabaTc,
                            MedeniHal_kodu = k.MedeniHalKodu,
                            MedeniHal_aciklamasi = k.MedeniHal.Aciklamasi,
                            Durum_aciklamasi = k.Durum.Aciklamasi,
                            Durum_kodu = k.DurumKodu,
                            cinsiyet_kodu = k.CinsiyetKodu,
                            Tc = tc
                        }).FirstOrDefault();            
        }

        public static KisiBilgileri EsBilgileriGetir(string tc)
        {
            using (var context = new DbContextSingelton().Instance)
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

        public static DateTime? Dogumtarihi(string tc)
        {
            using (var context = new DbContextSingelton().Instance)
                return context.OlayGecmisi
                    .Include(k => k.Kisi)
                    .Where(k => k.KisiTc == tc)
                    .Select(k => k.Zaman)
                    .FirstOrDefault();
        }
    }
}