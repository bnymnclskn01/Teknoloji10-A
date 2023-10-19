using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Log
{
    public int Id { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Uye { get; set; }

    public string? IpAdresi { get; set; }

    public string? Islem { get; set; }

    public string? Logtype { get; set; }
}
