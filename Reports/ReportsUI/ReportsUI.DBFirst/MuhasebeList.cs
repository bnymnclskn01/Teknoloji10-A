using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class MuhasebeList
{
    public DateTime? DekontOdemeTarihi { get; set; }

    public string? FaturaNo { get; set; }

    public string? DosyaAdi { get; set; }

    public int? TarafId { get; set; }

    public string? TarafDosyaNo { get; set; }

    public string? DosyaParaBirim { get; set; }

    public string? DosyaNo { get; set; }

    public int DosyaId { get; set; }

    public int? OdemeId { get; set; }

    public string? OdemeTipi { get; set; }

    public string BankaTipi { get; set; } = null!;

    public string Faturami { get; set; } = null!;

    public decimal? Tahsilattutari { get; set; }

    public string? Tahsilatparabirimi { get; set; }

    public string? GonderenKurum { get; set; }

    public decimal? BorcTutari { get; set; }

    public decimal? Asilalacaktutari { get; set; }

    public DateTime? TahsilatTarihi { get; set; }

    public DateTime? OlusturulmaTarih { get; set; }
}
