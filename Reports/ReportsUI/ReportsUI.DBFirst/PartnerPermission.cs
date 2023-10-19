using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class PartnerPermission
{
    public int Id { get; set; }

    public int? TarafId { get; set; }

    public string? Muhasebe { get; set; }

    public string? Hukuk { get; set; }

    public string? Raporlama { get; set; }

    public string? IstihbaratDokumasyon { get; set; }

    public string? Yonetim { get; set; }

    public string? AdliTakip { get; set; }

    public string? Arama { get; set; }

    public string? IsGelistirme { get; set; }

    public string? YoneticiAvukat { get; set; }
}
