using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class EtkinlikTakvimi
{
    public int Id { get; set; }

    public string? ClassName { get; set; }

    public string? Aciklama { get; set; }

    public int? UserId { get; set; }

    public string? Detay { get; set; }

    public string? EtkinlikTipi { get; set; }

    public string? StartDate { get; set; }

    public string? Title { get; set; }

    public int? Dosyaid { get; set; }

    public DateTime? NormalizeDate { get; set; }
}
