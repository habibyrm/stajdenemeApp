using System;
using System.Collections.Generic;

namespace stajdenemeApp.Models;

public partial class Cilt
{
    public int IdCilt { get; set; }

    public int? SehirKodu { get; set; }

    public string? Aciklamasi { get; set; }

    public virtual ICollection<Aile> Ailes { get; set; } = new List<Aile>();

    public virtual Sehir? SehirKoduNavigation { get; set; }
}
