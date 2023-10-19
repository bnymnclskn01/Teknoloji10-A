using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class MuhasebeMasrafAvansDetay
{
    public int Id { get; set; }

    public string? Faturano { get; set; }

    public decimal? MasrafTutar { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public int? KayitUser { get; set; }
}
