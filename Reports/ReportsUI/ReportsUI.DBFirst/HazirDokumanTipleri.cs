using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class HazirDokumanTipleri
{
    public int Id { get; set; }

    public string? DokumanAdi { get; set; }

    public string? Icerik { get; set; }

    public DateTime? CreateDate { get; set; }
}
