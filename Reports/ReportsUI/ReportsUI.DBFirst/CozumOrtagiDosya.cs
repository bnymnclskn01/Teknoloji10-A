using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtagiDosya
{
    public int Id { get; set; }

    public int? CozumortagiId { get; set; }

    public string? DosyaNo { get; set; }

    public string? DosyaAdi { get; set; }

    public decimal? BorcTutari { get; set; }

    public string? ParaBirimi { get; set; }

    public decimal? Faiz { get; set; }

    public decimal? Komisyon { get; set; }

    public decimal? Kdv { get; set; }

    public DateTime? OlusturulmaTarihi { get; set; }

    public string? CustomerFileMessageType { get; set; }

    public DateTime? GuncellenmeTarih { get; set; }

    public string? CustomerFileMessageStatusValue { get; set; }

    public int? OlusturanPersonel { get; set; }

    public int? GuncelleyenPersonel { get; set; }

    public string? Gorevliler { get; set; }

    public decimal? DigerVergi { get; set; }

    public string? CozumortagidosyaNo { get; set; }

    public string? GenelBilgi { get; set; }

    public int? DosyaTipi { get; set; }

    public int? Invoicebankaid { get; set; }

    public int? Collectionbankaid { get; set; }

    public decimal? Asilalacaktutari { get; set; }

    public string? DosyaDurumu { get; set; }

    public string? Dosyaislem { get; set; }

    public string? CustomerFileMessageStatus { get; set; }

    public string? PartnersClientNo { get; set; }

    public string? PartnersClaimNo { get; set; }

    public string? PartnersClientClaimNo { get; set; }

    public decimal? PartnersCost { get; set; }

    public decimal? PartnersInterestAmount { get; set; }

    public int? FileStatusId { get; set; }

    public DateTime? KapatmaTarihi { get; set; }

    public string? KalanBorcTutari { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<CozumOrtagiDosyaGelismeler> CozumOrtagiDosyaGelismelers { get; set; } = new List<CozumOrtagiDosyaGelismeler>();

    public virtual ICollection<CozumOrtagiDosyaOdemeler> CozumOrtagiDosyaOdemelers { get; set; } = new List<CozumOrtagiDosyaOdemeler>();

    public virtual CozumOrtaklari? Cozumortagi { get; set; }
}
