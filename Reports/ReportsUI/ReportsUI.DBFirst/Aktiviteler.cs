using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Aktiviteler
{
    public int Id { get; set; }

    public string? AktiviteAdi { get; set; }

    public string? AktiviteNotu { get; set; }

    public int? AktiviteIhtimali { get; set; }

    public string? Gorevliler { get; set; }

    public DateTime? OlusturulmaTarihi { get; set; }

    public DateTime? SonTarihi { get; set; }

    public int? DosyaId { get; set; }

    public string? Durum { get; set; }

    public int? OlusturanPersonel { get; set; }

    public int? OdemeId { get; set; }

    public string? OdemeParaBirimi { get; set; }

    public int? FaturaId { get; set; }

    public string? Yetkigrubu { get; set; }

    public DateTime? BaslamaTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public int? IsCustomer { get; set; }

    public int? UpdateUserid { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsWait { get; set; }
}
