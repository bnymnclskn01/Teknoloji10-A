using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtagiDosyaDavalar
{
    public int Id { get; set; }

    public int? DosyaId { get; set; }

    public string? DavaTuru { get; set; }

    public string? Mahkeme { get; set; }

    public string? DavaDosyaEsasNo { get; set; }

    public string? DosyaKararNo { get; set; }

    public DateTime? DavaTarihi { get; set; }

    public string? DavaDegeri { get; set; }

    public string? ParaBirimi { get; set; }

    public DateTime? DurusmaTarihi { get; set; }

    public DateTime? OlusturulmaTarihi { get; set; }

    public int? OlusturanPersonel { get; set; }

    public string? DosyaAdi { get; set; }

    public string? AlacakliAdi { get; set; }

    public string? BorcluAdi { get; set; }

    public int? TakipTuruId { get; set; }

    public int? IcraDairesiId { get; set; }

    public int? GorevDurumu { get; set; }

    public string? Aciklama { get; set; }
}
