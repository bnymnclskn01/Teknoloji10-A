using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class AktiviteIhtimalleriArsiv
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public string? Ihtimal { get; set; }

    public string? Gorevliler { get; set; }

    public int? IsValidateType { get; set; }
}
