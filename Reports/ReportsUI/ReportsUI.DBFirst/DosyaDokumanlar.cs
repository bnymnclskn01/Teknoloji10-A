using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class DosyaDokumanlar
{
    public int Id { get; set; }

    public string? DokumanAdi { get; set; }

    public string? ArsivYolu { get; set; }

    public string? DosyaGuid { get; set; }

    public string? OlusturmaTarihi { get; set; }

    public int DosyaNo { get; set; }

    public string? Dosyauzantisi { get; set; }

    public string? Departman { get; set; }

    public int? GuncellemeUser { get; set; }

    public DateTime? GuncellemeTarihi { get; set; }

    public bool? IsUpdate { get; set; }

    public int? VersionNumber { get; set; }

    public string? DosyaTipi { get; set; }
}
