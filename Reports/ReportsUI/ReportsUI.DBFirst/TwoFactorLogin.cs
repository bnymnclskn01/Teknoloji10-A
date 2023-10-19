using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class TwoFactorLogin
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string? Code { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IsActive { get; set; }
}
