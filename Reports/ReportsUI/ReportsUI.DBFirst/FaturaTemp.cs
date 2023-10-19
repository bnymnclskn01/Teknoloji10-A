using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class FaturaTemp
{
    public string? FaturaNo { get; set; }

    public decimal? FaturaTutari { get; set; }

    public double? İlgiliDosya { get; set; }

    public string? Taraf { get; set; }

    public string? Borclu { get; set; }

    public string? ParaBirimi { get; set; }

    public string? TahsilatTutarı { get; set; }

    public string? TParaBirimi { get; set; }

    public string? FaturaTipi { get; set; }

    public DateTime? KTarihi { get; set; }

    public string? Banka { get; set; }

    public string? Durumu { get; set; }

    public string? İşlem { get; set; }
}
