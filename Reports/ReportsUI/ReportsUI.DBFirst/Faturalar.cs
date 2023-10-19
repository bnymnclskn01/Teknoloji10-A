using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Faturalar
{
    public int Id { get; set; }

    public string? FaturaNo { get; set; }

    public string? Tutar { get; set; }

    public int? Komisyon { get; set; }

    public string? OdemeBankası { get; set; }

    public string? Taraf { get; set; }

    public string? TarafAdres { get; set; }

    public string? TarafMail { get; set; }

    public string? FaturaTarihi { get; set; }
}
