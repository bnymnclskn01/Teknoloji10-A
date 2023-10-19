using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class DosyaKategoriler
{
    public int Id { get; set; }

    public string? Kategori { get; set; }

    public int? DosyaId { get; set; }

    public string? DosyaAdi { get; set; }
}
