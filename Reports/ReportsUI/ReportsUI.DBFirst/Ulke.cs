using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Ulke
{
    public int Id { get; set; }

    public string? UlkeAdi { get; set; }

    public int? Oncelik { get; set; }

    public string? TrTr { get; set; }

    public string EnUs { get; set; } = null!;
}
