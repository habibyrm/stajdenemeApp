using System;
using System.Collections.Generic;

namespace stajdenemeApp.Models;

public partial class Cinsiyet
{
    public int IdCinsiyet { get; set; }

    public string? Aciklamasi { get; set; }

    public virtual ICollection<Kisi> Kisis { get; set; } = new List<Kisi>();
}
