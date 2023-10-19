using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtagiDosyaTeminatlar
{
    public int Id { get; set; }

    public int? DosyaId { get; set; }

    public string? Teminat { get; set; }

    public string? TeminatNotu { get; set; }

    public DateTime? OlusturulmaTarihi { get; set; }

    public int? OlusturanPersonel { get; set; }

    public DateTime? GuncellemeTarihi { get; set; }

    public int? GuncelleyenPersonel { get; set; }
}
