using Microsoft.EntityFrameworkCore;
using stajdenemeApp.Core;
using stajdenemeApp.Models;
using System.Windows.Forms;


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

        public static int Cilt_Kontrol(string cilt)
        {
            if (cilt == "Küçükçekmece-İstanbul")
            {
                return 1;
            }
            else if (cilt == "Bakırköy - İstanbul")
            {
                return 2;
            }
            else if (cilt == "Atakent - İstanbul")
            {
                return 3;
            }
            else if (cilt == "YeşilKöy - İstanbul")
            {
                return 4;
            }
            else if (cilt == "Bostancı - İstanbul")
            {
                return 5;
            }
            else if (cilt == "Çankaya - Ankara")
            {
                return 6;
            }
            else if (cilt == "Yenimahalle - Ankara")
            {
                return 7;
            }
            else if (cilt == "Eryaman - Ankara")
            {
                return 8;
            }
            else if (cilt == "İncek - Ankara")
            {
                return 9;
            }
            else if (cilt == "Polatlı - Ankara")
            {
                return 10;
            }
            else if (cilt == "Serdivan - Sakarya")
            {
                return 11;
            }
            else if (cilt == "Akyazı - Sakarya")
            {
                return 12;
            }
            else if (cilt == "Sapanca - Sakarya")
            {
                return 13;
            }
            else if (cilt == "Hendek - Sakarya")
            {
                return 14;
            }
            else if (cilt == "Arifiye - Sakarya")
            {
                return 15;
            }
            else if (cilt == "Reşadiye - Tokat")
            {
                return 16;
            }
            else if (cilt == "Zile - Tokat")
            {
                return 17;
            }
            else if (cilt == "Niksar - Tokat")
            {
                return 18;
            }
            else if (cilt == "Almus - Tokat")
            {
                return 19;
            }
            else if (cilt == "Pazar - Tokat")
            {
                return 20;
            }
            else if (cilt == "Bereketli - Tokat")
            {
                return 21;
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
                            BireySiraNo = k.Aile.BireySiraNo.Value,
                            EsTc=k.Aile.EsTc
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