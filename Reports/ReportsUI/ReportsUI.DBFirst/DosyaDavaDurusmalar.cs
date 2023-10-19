using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class DosyaDavaDurusmalar
{
    public int Id { get; set; }

    public int? Davaid { get; set; }

    public string? DavaAdi { get; set; }

    public string? DurumsaNotu { get; set; }

    public DateTime? Tarih { get; set; }

    public TimeSpan? Saat { get; set; }

    public int? KayitUser { get; set; }

    public DateTime? KayitTarih { get; set; }

    public int? Dosyaid { get; set; }

    public string? DurusmaTipi { get; set; }

    public string? Dokumanadi { get; set; }

    public int? GorevDurumu { get; set; }
}
