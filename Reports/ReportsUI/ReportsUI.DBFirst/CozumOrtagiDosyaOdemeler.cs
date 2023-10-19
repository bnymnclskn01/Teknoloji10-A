using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtagiDosyaOdemeler
{
    public int Id { get; set; }

    public int? DosyaId { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public decimal? OdemeTutari { get; set; }

    public int? OlusturanPersonel { get; set; }

    public string? Onay { get; set; }

    public string? ParaBirimi { get; set; }

    public DateTime? TahsilatTarihi { get; set; }

    public string? OdemeTipi { get; set; }

    public int? IsInvoice { get; set; }

    public int? BankaTipi { get; set; }

    public int? Bankaid { get; set; }

    public string? DovizKuru { get; set; }

    public decimal? FaturaTutari { get; set; }

    public int? IsNotProgress { get; set; }

    public int? Faturaid { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? IsPayedDate { get; set; }

    public int? IsCustomer { get; set; }

    public int? IsDelete { get; set; }

    public decimal? Kurdegeri { get; set; }

    public DateTime? KurTarihi { get; set; }

    public decimal? KurTutariTl { get; set; }

    public DateTime? GuncellemeTarihi { get; set; }

    public decimal? ExChangeNetTotal { get; set; }

    public virtual CozumOrtagiDosya? Dosya { get; set; }
}
