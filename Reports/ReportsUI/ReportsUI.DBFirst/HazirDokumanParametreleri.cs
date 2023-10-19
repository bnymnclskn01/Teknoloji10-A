using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class HazirDokumanParametreleri
{
    public int Id { get; set; }

    public string? ParamName { get; set; }

    public string? ParamKey { get; set; }

    public string? ParamValue { get; set; }

    public string? Sifati { get; set; }
}
