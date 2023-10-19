using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class FeedBack
{
    public int Id { get; set; }

    public string? Baslik { get; set; }

    public string? Aciklama { get; set; }

    public string? Adres { get; set; }

    public int? Userid { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Durumu { get; set; }
}
