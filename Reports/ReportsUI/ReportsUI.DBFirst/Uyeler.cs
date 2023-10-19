using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Uyeler
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? Email { get; set; }

    public string? KullaniciAdi { get; set; }

    public string? Sifre { get; set; }

    public string? Gsm { get; set; }

    public string? TelDahili { get; set; }

    public string? ProfilResmi { get; set; }

    public int? Durum { get; set; }

    public string? Departmanlar { get; set; }

    public string? Roller { get; set; }
}
