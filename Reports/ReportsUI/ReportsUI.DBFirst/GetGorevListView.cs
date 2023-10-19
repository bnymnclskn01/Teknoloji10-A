using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class GetGorevListView
{
    public int? PartnerId { get; set; }

    public int? YapimSuresi { get; set; }

    public int? DiffDay { get; set; }

    public DateTime? BaslamaTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public string? Aktivite { get; set; }

    public string? Taraf { get; set; }

    public int Gid { get; set; }

    public string? Ihtimal { get; set; }

    public string? DosyaAdi { get; set; }

    public int? Dosyaid { get; set; }

    public string? Gorevliler { get; set; }

    public string? Durum { get; set; }

    public int? Id { get; set; }

    public int? Iscompleted { get; set; }

    public string? DosyaNo { get; set; }

    public string? DosyaTipi { get; set; }
}
