using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class GetAktiviteListView
{
    public int Id { get; set; }

    public DateTime? SonTarihi { get; set; }

    public string? DosyaAdi { get; set; }

    public int? DosyaId { get; set; }

    public string? Durum { get; set; }

    public string? AktiviteAdi { get; set; }

    public string? Ihtimal { get; set; }

    public string? OlusturanPersonel { get; set; }

    public string? Gorevliler { get; set; }

    public int? GelismeId { get; set; }
}
