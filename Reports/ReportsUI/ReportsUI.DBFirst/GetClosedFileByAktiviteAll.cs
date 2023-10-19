using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class GetClosedFileByAktiviteAll
{
    public int? DosyaId { get; set; }

    public string? DosyaNo { get; set; }

    public string? DosyaAdi { get; set; }

    public int Aktiviteid { get; set; }

    public string? AktiviteDurum { get; set; }

    public string? DosyaDurum { get; set; }

    public string? AktiviteAdi { get; set; }
}
