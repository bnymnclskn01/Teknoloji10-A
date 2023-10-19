using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class GetInvoiceList
{
    public int Id { get; set; }

    public string? FaturaNo { get; set; }

    public decimal? TahsilatTutari { get; set; }

    public string? TahsilatParaBirimi { get; set; }

    public int? InvoiceStatus { get; set; }

    public int? BatchId { get; set; }

    public string? Aciklama { get; set; }

    public string? MusteriAciklama { get; set; }

    public string? Durum { get; set; }

    public string? DosyaNo { get; set; }

    public string? DuzenlemeTarihi { get; set; }

    public int? OdemeId { get; set; }

    public string? BuroDosyalar { get; set; }

    public string IsMainBatch { get; set; } = null!;

    public decimal? Kdv { get; set; }

    public string? TarafDosyaNo { get; set; }

    public decimal? Iskonto { get; set; }

    public string? Borclu { get; set; }

    public int? BorcluId { get; set; }

    public string? BacthInvoiceId { get; set; }

    public string? OrganizaitonName { get; set; }

    public string? VergiDairesi { get; set; }

    public string? VergiNumarasi { get; set; }

    public string? OrganizaitonAdres { get; set; }

    public string? OrganizaitonPostaKodu { get; set; }

    public string? OrganizaitonSehir { get; set; }

    public string? SabitTelefon { get; set; }

    public string? OrganizaitonEmail { get; set; }

    public string? OrganizaitonUlke { get; set; }

    public string? OrganizaitonUlkeEn { get; set; }

    public string? OrganizaitonBanka { get; set; }

    public string? OrganizaitonBankaSubeKodu { get; set; }

    public string? OrganizaitoSwiftCode { get; set; }

    public string? OrganizaitonBankaHesapSahibi { get; set; }

    public string? OrganizaitonIban { get; set; }

    public string? OrganizaitonBankaSubeAdi { get; set; }

    public string? OrganizaitonBankaHesapNumarasi { get; set; }

    public string? OrganizaitonRoutingNumber { get; set; }

    public string? OrganizaitonCurrency { get; set; }

    public string? IlgiliDosya { get; set; }

    public decimal? FaturaTutari { get; set; }

    public string? DekontOdemeTarihi { get; set; }

    public int? InvoiceBanka { get; set; }

    public string? ParaBirimi { get; set; }

    public string? HareketTipi { get; set; }

    public string? FaturaHesabı { get; set; }

    public string? TarafBanka { get; set; }

    public int? HareketId { get; set; }

    public string? ExchangeRate { get; set; }

    public string? Taraf { get; set; }

    public int? Tarafid { get; set; }

    public decimal? Komisyon { get; set; }

    public string? FaturaGonderimTarihi { get; set; }

    public string? TahsilatTarihi { get; set; }

    public decimal? NetTotal { get; set; }
}
