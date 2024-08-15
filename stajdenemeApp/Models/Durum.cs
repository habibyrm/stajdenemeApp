using System;
using System.Collections.Generic;

namespace stajdenemeApp.Models;

public partial class Durum
{
    public int IdDurum { get; set; }

    public string? Aciklamasi { get; set; }

    public virtual ICollection<Kisi> Kisis { get; set; } = new List<Kisi>();
}
