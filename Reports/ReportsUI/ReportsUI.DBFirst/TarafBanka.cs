using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class TarafBanka
{
    public int Id { get; set; }

    public int? TarafId { get; set; }

    public string? BankaAdi { get; set; }

    public string? SubeKodu { get; set; }

    public string? HesapSahibi { get; set; }

    public string? HesapNumarasi { get; set; }

    public string? IbanNumarasi { get; set; }

    public string? SwiftKodu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? EklenmeTarihi { get; set; }
}
