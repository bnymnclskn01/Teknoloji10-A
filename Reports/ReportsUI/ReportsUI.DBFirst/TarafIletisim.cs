using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class TarafIletisim
{
    public int Id { get; set; }

    public int? TarafId { get; set; }

    public string? SabitTelefon { get; set; }

    public string? FaksNumarasi { get; set; }

    public string? GsmNumarasi { get; set; }

    public string? EmailAdresi { get; set; }

    public string? WebSitesi { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? EklenmeTarihi { get; set; }
}
