using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class IcraDavaDurusmalar
{
    public int Id { get; set; }

    public int? Icraid { get; set; }

    public string? Icratakipeesasno { get; set; }

    public string? IslemNotu { get; set; }

    public string? IslemTipi { get; set; }

    public DateTime? Tarih { get; set; }

    public TimeSpan? Saat { get; set; }

    public int? KayitUser { get; set; }

    public DateTime? KayitTarih { get; set; }

    public int? Dosyaid { get; set; }

    public string? Dokumanadi { get; set; }

    public int? GorevDurumu { get; set; }
}
