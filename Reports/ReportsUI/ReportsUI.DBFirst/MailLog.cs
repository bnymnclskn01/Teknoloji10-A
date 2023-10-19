using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class MailLog
{
    public int Id { get; set; }

    public string? MailAddress { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Islem { get; set; }

    public string? Logtype { get; set; }

    public int? CustomerMailId { get; set; }
}
