using System;
using System.Collections.Generic;

namespace stajdenemeApp.Models;

public partial class Kisi
{
    public int IdKisi { get; set; }

    public string Tc { get; set; } = null!;

    public int? DurumKodu { get; set; }

    public int? MedeniHalKodu { get; set; }

    public int? CinsiyetKodu { get; set; }

    public int? DogumYeriKodu { get; set; }

    public int? AileKodu { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public virtual Aile Aile { get; set; }

    public virtual Cinsiyet Cinsiyet { get; set; }

    public virtual Sehir Sehir { get; set; }

    public virtual Durum Durum { get; set; }

    public virtual Medenihal Medenihal { get; set; }

    public virtual ICollection<OlayGecmisi> OlayGecmisi { get; set; } = new List<OlayGecmisi>();
}
