using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class DosyaDokumanlarVersionArsiv
{
    public int Id { get; set; }

    public int? DokumanId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateUser { get; set; }

    public int? VersionNumber { get; set; }

    public string? DokumanAdi { get; set; }

    public string? ArsivYolu { get; set; }

    public string? DosyaGuid { get; set; }

    public int? DosyaNo { get; set; }

    public string? Dosyauzantisi { get; set; }

    public string? Departman { get; set; }
}
