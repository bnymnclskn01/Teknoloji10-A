using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class FaturaTipleri
{
    public int Id { get; set; }

    public string? FaturaTipi { get; set; }

    public decimal? Tutar { get; set; }

    public int? IsArsivFileView { get; set; }

    public string? ParaBirimi { get; set; }

    public int? IsMasraf { get; set; }

    public int? IsBatchClose { get; set; }

    public int? FaturaDurumuId { get; set; }

    public int? AktiviteId { get; set; }
}
