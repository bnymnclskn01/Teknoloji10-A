using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Muhasebefatura
{
    public int? OdemeId { get; set; }

    public string? ExchangeRate { get; set; }

    public string? ParaBirimi { get; set; }

    public string? Faturaparabirimi { get; set; }

    public decimal? Kurdegeri { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string? Kur2 { get; set; }
}
