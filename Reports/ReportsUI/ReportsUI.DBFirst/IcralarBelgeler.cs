using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class IcralarBelgeler
{
    public int Id { get; set; }

    public string? DokumanAdi { get; set; }

    public string? Dokuman { get; set; }

    public int? KategoriId { get; set; }

    public string? Klasor { get; set; }
}
