using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CustomerMailList
{
    public int Id { get; set; }

    public int? Tarafid { get; set; }

    public string? MailAdresi { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public int? GonderenUser { get; set; }

    public string? Mailicerik { get; set; }

    public int? Durum { get; set; }

    public string? Cc { get; set; }

    public string? Baslik { get; set; }

    public string? Dokumanlar { get; set; }

    public int? Dosyano { get; set; }

    public string? FilePath { get; set; }
}
