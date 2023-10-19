using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class MuhasebeMasrafAvan
{
    public int Id { get; set; }

    public int? Faturaid { get; set; }

    public decimal? Tutar { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public int? KayitPersonel { get; set; }

    public string? Dosyaid { get; set; }

    public string? HaraketTuru { get; set; }

    public string? FaturaNo { get; set; }

    public decimal? KalanTutar { get; set; }

    public string? ParaBirimi { get; set; }
}
