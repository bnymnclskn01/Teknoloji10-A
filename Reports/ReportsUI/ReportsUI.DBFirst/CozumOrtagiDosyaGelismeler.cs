using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtagiDosyaGelismeler
{
    public int Id { get; set; }

    public int? DosyaId { get; set; }

    public string? GelismeNotu { get; set; }

    public DateTime? GelismeTarihi { get; set; }

    public int? OlusturanPersonel { get; set; }

    public DateTime? OlusturmaTarihi { get; set; }

    public int? GuncelleyenPersonel { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? Eknot { get; set; }

    public int? IsHtml { get; set; }

    public int? IsCustomer { get; set; }

    public DateTime? IsPayedDate { get; set; }

    public virtual CozumOrtagiDosya? Dosya { get; set; }
}
