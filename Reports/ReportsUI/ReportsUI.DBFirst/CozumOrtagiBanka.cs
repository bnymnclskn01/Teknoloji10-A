using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtagiBanka
{
    public int Id { get; set; }

    public int? CozumortagiId { get; set; }

    public string? BankaAdi { get; set; }

    public string? SubeKodu { get; set; }

    public string? HesapSahibi { get; set; }

    public string? HesapNumarasi { get; set; }

    public string? IbanNumarasi { get; set; }

    public string? SwiftKodu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? EklenmeTarihi { get; set; }

    public string? Birincil { get; set; }

    public string? KayitTipi { get; set; }

    public string? Ekleyen { get; set; }

    public string? SubeAdi { get; set; }

    public string? RoutingName { get; set; }

    public string? Currency { get; set; }

    public string? Hesapadi { get; set; }
}
