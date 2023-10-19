using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Arsivfaturakaktivite
{
    public int Id { get; set; }

    public int? FaturaId { get; set; }

    public int? Aktiviteid { get; set; }
}
