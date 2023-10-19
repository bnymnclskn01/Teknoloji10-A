using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Currency
{
    public int Id { get; set; }

    public string? CrossOrder { get; set; }

    public string? Kod { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Unit { get; set; }

    public string? Isim { get; set; }

    public string? CurrencyName { get; set; }

    public string? ForexBuying { get; set; }

    public string? ForexSelling { get; set; }

    public string? BanknoteBuying { get; set; }

    public string? BanknoteSelling { get; set; }

    public string? CrossRateUsd { get; set; }

    public string? CrossRateOther { get; set; }

    public string? Tarih { get; set; }

    public string? BultenNo { get; set; }

    public string? Ddate { get; set; }
}
