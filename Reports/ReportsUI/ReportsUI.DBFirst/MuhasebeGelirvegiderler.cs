using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class MuhasebeGelirvegiderler
{
    public int Id { get; set; }

    public int? BankaId { get; set; }

    public string? HareketTipi { get; set; }

    public int? CozumortagiId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? ParaBirimi { get; set; }

    public string? IlgiliSmm { get; set; }

    public string? IlgiliDosya { get; set; }

    public string? DokumanDurumu { get; set; }

    public int? KayitSahibi { get; set; }

    public string? Aciklama { get; set; }

    public string? Durum { get; set; }

    public string? HaraketTuruAdi { get; set; }

    public int? InvoiceBanka { get; set; }

    public int? InvoiceStatus { get; set; }

    public string? FaturaNo { get; set; }

    public decimal? FaturaTutari { get; set; }

    public string? Roller { get; set; }

    public int? BankaOdemeYeri { get; set; }

    public string? ExchangeRate { get; set; }

    public int? HareketId { get; set; }

    public int? Tarafbankaid { get; set; }

    public int? BorcluId { get; set; }

    public decimal? Komisyon { get; set; }

    public int? OdemeId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public DateTime? FaturaGonderimTarihi { get; set; }

    public int? BatchId { get; set; }

    public string? TarafDosyaNo { get; set; }

    public string? BacthInvoiceId { get; set; }

    public int? InvoiceOrganizaitonId { get; set; }

    public string? BuroDosyalar { get; set; }

    public int? IsMainBatch { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Iskonto { get; set; }

    public decimal? Tutar { get; set; }

    public decimal? TahsilatTutari { get; set; }

    public string? TahsilatParaBirimi { get; set; }

    public decimal? NetTotal { get; set; }

    public int? IsDeleted { get; set; }

    public string? MusteriAciklama { get; set; }

    public int? Aktiviteid { get; set; }

    public decimal? Tlkurtari { get; set; }
}
