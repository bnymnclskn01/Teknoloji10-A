using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class AktiviteGelismeleri
{
    public int Id { get; set; }

    public int? AktiviteId { get; set; }

    public int? GelismeId { get; set; }

    public string? GelismeNotu { get; set; }

    public DateTime? OlusturulmaTarihi { get; set; }

    public int? OlusturanPersonel { get; set; }

    public int? IhtimalId { get; set; }

    public string? Gorevliler { get; set; }

    public int? Iscompleted { get; set; }

    public int? Faturaid { get; set; }

    public int? AktivitelerId { get; set; }

    public int? IsCustomer { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? CustomerNote { get; set; }
}
