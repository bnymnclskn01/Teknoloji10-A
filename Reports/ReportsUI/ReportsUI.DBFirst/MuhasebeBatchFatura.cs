using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class MuhasebeBatchFatura
{
    public int Id { get; set; }

    public string? FaturaNo { get; set; }

    public int? Faturaid { get; set; }

    public int? BatchFaturaid { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public int? KayitUser { get; set; }

    public decimal? Tutar { get; set; }

    public string? Dosyano { get; set; }
}
