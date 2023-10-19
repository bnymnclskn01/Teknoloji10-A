using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtagiDosyaTaraflar
{
    public int Id { get; set; }

    public int? TarafId { get; set; }

    public string? TarafSifati { get; set; }

    public int? DosyaId { get; set; }

    public int? SifatId { get; set; }
}
