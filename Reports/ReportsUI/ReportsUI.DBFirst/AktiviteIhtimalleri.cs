using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class AktiviteIhtimalleri
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public string? Ihtimal { get; set; }

    public string? Gorevliler { get; set; }

    public int? IsValidateType { get; set; }

    public int? IsAction { get; set; }

    public int? IsMain { get; set; }

    public int? Invoiceid { get; set; }

    public int? Bagliihtimal { get; set; }

    public int? Isdelete { get; set; }

    public int? IsPayed { get; set; }

    public string? IhtimalEn { get; set; }
}
