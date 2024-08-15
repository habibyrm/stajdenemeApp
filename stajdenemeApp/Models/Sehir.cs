using System;
using System.Collections.Generic;

namespace stajdenemeApp.Models;

public partial class Sehir
{
    public int IdSehir { get; set; }

    public int? Kodu { get; set; }

    public string? Aciklamasi { get; set; }

    public virtual ICollection<Cilt> Cilts { get; set; } = new List<Cilt>();

    public virtual ICollection<Kisi> Kisis { get; set; } = new List<Kisi>();
}
