using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class BankaBilgileri
{
    public int Id { get; set; }

    public string? BankaAdi { get; set; }

    public string? SubeKodu { get; set; }

    public string? HesapSahibi { get; set; }

    public string? HesapNumarasi { get; set; }

    public string? IbanNumarasi { get; set; }

    public string? SwiftKodu { get; set; }

    public string? ParaBirimi { get; set; }

    public string? HesapAdi { get; set; }

    public string? SubeAdi { get; set; }

    public string? RoutingNumber { get; set; }
}
