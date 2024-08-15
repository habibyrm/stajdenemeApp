using stajdenemeApp.Models;

namespace stajdenemeApp.ComplexModels
{
    public class OlayKayit
    {
        public void OlayKaydi(string tc, DateTime zaman, int olaykodu)
        {
            using (var context = new DbContextSingelton().Instance)
            {
                var olay = new OlayGecmisi
                {
                    KisiTc = tc,
                    OlayKodu = olaykodu,
                    KullaniciId = CurrentUser.KullaniciId,
                    Zaman = zaman
                };

                context.OlayGecmisi.Add(olay);
                context.SaveChanges();
            }
        }
        public void OlayKaydi(string tc, string es_tc, DateTime zaman, int olaykodu)
        {
            using (var context = new DbContextSingelton().Instance)
            {
                var olay = new OlayGecmisi
                {
                    KisiTc = tc,
                    EsTc = es_tc,
                    OlayKodu = olaykodu,
                    KullaniciId = CurrentUser.KullaniciId,
                    Zaman = zaman
                };

                context.OlayGecmisi.Add(olay);
                context.SaveChanges();
            }
        }
    }
}
