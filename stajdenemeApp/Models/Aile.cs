using System;
using System.Collections.Generic;

namespace stajdenemeApp.Models;

public partial class Aile
{
    public int IdAile { get; set; }

    public int? AileSiraNo { get; set; }

    public int? BireySiraNo { get; set; }

    public string AnneTc { get; set; } = null!;

    public string BabaTc { get; set; } = null!;

    public string? EsTc { get; set; }

    public int CiltKodu { get; set; }

    public virtual Cilt CiltKoduNavigation { get; set; } = null!;

    public virtual ICollection<Kisi> Kisis { get; set; } = new List<Kisi>();
}
