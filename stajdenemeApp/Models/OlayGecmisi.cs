using System;
using System.Collections.Generic;

namespace stajdenemeApp.Models;

public partial class OlayGecmisi
{
    public int IdOlayGecmisi { get; set; }

    public int? OlayKodu { get; set; }

    public string? KisiTc { get; set; }

    public DateOnly? Tarihi { get; set; }

    public TimeOnly? Saat { get; set; }

    public DateTime? Zaman { get; set; }

    public int? KullaniciId { get; set; }

    public virtual Kisi Kisi { get; set; }

    public virtual Kullanici Kullanici { get; set; }

    public virtual Olay Olay { get; set; }
}
