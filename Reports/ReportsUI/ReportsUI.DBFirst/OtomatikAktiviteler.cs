using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class OtomatikAktiviteler
{
    public int Id { get; set; }

    public string? AktiviteAdi { get; set; }

    public string? AktiviteNotu { get; set; }

    public int? AktiviteIhtimali { get; set; }

    public string? HangiIslemler { get; set; }

    public int? Durum { get; set; }

    public string? Gorevliler { get; set; }

    public int? GorevSuresi { get; set; }

    public int? GecikmeSuresi { get; set; }

    public string? DosyaTipi { get; set; }
}
