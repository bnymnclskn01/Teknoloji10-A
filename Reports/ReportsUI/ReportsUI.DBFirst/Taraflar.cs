using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Taraflar
{
    public int Id { get; set; }

    public int? TarafNo { get; set; }

    public string? TarafAdi { get; set; }

    public string? Sektor { get; set; }

    public string? TicariUnvan { get; set; }

    public string? VergiNumarasi { get; set; }

    public string? VergiDairesi { get; set; }

    public DateTime? OlusturulmaTarihi { get; set; }

    public int? OlusturanPersonel { get; set; }

    public DateTime? GuncellemeTarih { get; set; }

    public int? GuncellemePersonel { get; set; }

    public string? KimlikNo { get; set; }

    public string? DogumTarihi { get; set; }

    public string? SeriNo { get; set; }

    public string? No { get; set; }

    public string? AnaAdi { get; set; }

    public string? BabaAdi { get; set; }

    public string? DogumYeri { get; set; }

    public string? Cinsiyet { get; set; }

    public string? MedeniHali { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? OncekiSoyadi { get; set; }
}
