using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class AktivitelerOdemeFatura
{
    public int Id { get; set; }

    public int? OdemeId { get; set; }

    public decimal? Tutar { get; set; }

    public string? ParaBirimi { get; set; }

    public int? AktiviteId { get; set; }

    public int? DosyaId { get; set; }

    public DateTime? Tarih { get; set; }
}
