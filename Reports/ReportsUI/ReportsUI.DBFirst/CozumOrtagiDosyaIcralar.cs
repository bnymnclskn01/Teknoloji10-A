using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtagiDosyaIcralar
{
    public int Id { get; set; }

    public int? DosyaId { get; set; }

    public int? OlusturanPersonel { get; set; }

    public DateTime? OlusturulmaTarihi { get; set; }

    public string? TakipTuru { get; set; }

    public string? IcraDairesi { get; set; }

    public string? IcraTakipEsasNo { get; set; }

    public DateTime? TakipTarihi { get; set; }

    public decimal? TakipTutari { get; set; }

    public string? ParaBirimi { get; set; }

    public string? DosyaAdi { get; set; }

    public int? TakipTuruId { get; set; }

    public int? IcraDairesiId { get; set; }

    public string? BorcluAdi { get; set; }

    public string? AlacakliAdi { get; set; }

    public int? GorevDurumu { get; set; }

    public string? Aciklama { get; set; }
}
