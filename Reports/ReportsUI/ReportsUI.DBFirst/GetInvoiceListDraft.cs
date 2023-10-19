using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class GetInvoiceListDraft
{
    public string IsMainBatch { get; set; } = null!;

    public string? TarafDosyaNo { get; set; }

    public int? BatchId { get; set; }

    public int? InvoiceStatus { get; set; }

    public string? Borclu { get; set; }

    public string? BacthInvoiceId { get; set; }

    public int Id { get; set; }

    public string? FaturaNo { get; set; }

    public string? IlgiliDosya { get; set; }

    public decimal? Tutar { get; set; }

    public decimal? FaturaTutari { get; set; }

    public string? KayitTarihi { get; set; }

    public int? InvoiceBanka { get; set; }

    public string? ParaBirimi { get; set; }

    public int? HareketId { get; set; }

    public string? ExchangeRate { get; set; }

    public string? Taraf { get; set; }

    public int? Tarafid { get; set; }

    public decimal? Komisyon { get; set; }

    public string? DuzenlemeTarihi { get; set; }

    public string? FaturaGonderimTarihi { get; set; }
}
