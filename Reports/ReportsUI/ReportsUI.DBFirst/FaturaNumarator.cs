using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class FaturaNumarator
{
    public int Id { get; set; }

    public int FaturaNo { get; set; }

    public string? Tarih { get; set; }

    public int? IsActive { get; set; }

    public string? Type { get; set; }
}
