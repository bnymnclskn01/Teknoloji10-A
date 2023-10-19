using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class UyeTarih
{
    public int Id { get; set; }

    public int? UyeId { get; set; }

    public DateTime? Tarih { get; set; }
}
