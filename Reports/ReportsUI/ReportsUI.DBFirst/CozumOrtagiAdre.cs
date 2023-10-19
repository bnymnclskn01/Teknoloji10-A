using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtagiAdre
{
    public int Id { get; set; }

    public int? CozumortagiId { get; set; }

    public string? AdresBasligi { get; set; }

    public string? Ulke { get; set; }

    public string? Sehir { get; set; }

    public string? Ilce { get; set; }

    public string? Adres { get; set; }

    public string? PostaKodu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? EklenmeTarihi { get; set; }

    public string? Birincil { get; set; }

    public string? Ekleyen { get; set; }

    public string? KayitTipi { get; set; }
}
