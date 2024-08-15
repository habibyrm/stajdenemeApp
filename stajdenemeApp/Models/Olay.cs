using System;
using System.Collections.Generic;

namespace stajdenemeApp.Models;

public partial class Olay
{
    public int IdOlay { get; set; }

    public string? OlayYeri { get; set; }

    public string? Aciklamasi { get; set; }

    public virtual ICollection<OlayGecmisi> OlayGecmisis { get; set; } = new List<OlayGecmisi>();
}
