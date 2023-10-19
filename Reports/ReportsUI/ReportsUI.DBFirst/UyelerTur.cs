using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class UyelerTur
{
    public int Id { get; set; }

    public int? UyeId { get; set; }

    public int? Tur { get; set; }

    public DateTime? TurTarihi { get; set; }
}
