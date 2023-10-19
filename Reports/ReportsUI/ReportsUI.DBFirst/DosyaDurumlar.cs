using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class DosyaDurumlar
{
    public int Id { get; set; }

    public string? DurumAdi { get; set; }

    public string? NameEn { get; set; }

    public int? IsCustomer { get; set; }

    public string? PermissionGroup { get; set; }
}
