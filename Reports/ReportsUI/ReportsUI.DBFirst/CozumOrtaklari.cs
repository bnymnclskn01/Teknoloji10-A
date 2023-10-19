using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CozumOrtaklari
{
    public int Id { get; set; }

    public string? CozumortagiAdi { get; set; }

    public string? Sektor { get; set; }

    public int? IlgiliPersonel { get; set; }

    public string? TicariUnvan { get; set; }

    public string? VergiNumarasi { get; set; }

    public string? VergiDairesi { get; set; }

    public DateTime? OlusturulmaTarihi { get; set; }

    public int? OlusturanPersonel { get; set; }

    public DateTime? GuncellemeTarih { get; set; }

    public int? GuncellemePersonel { get; set; }

    public string? TarafYetkiliAdSoyad { get; set; }

    public string? Guid { get; set; }

    public string? TarafNormalize { get; set; }

    public string? Taraf { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? Taraftipi { get; set; }

    public string? DogumYeri { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Nufuskayityeri { get; set; }

    public string? Babaadi { get; set; }

    public string? Uyruk { get; set; }

    public string? Ailesirano { get; set; }

    public string? Serino { get; set; }

    public DateTime? Verilistarihi { get; set; }

    public string? Sehir { get; set; }

    public string? Ilce { get; set; }

    public string? Sirano { get; set; }

    public string? PartnerGuid { get; set; }

    public int? CustomerId { get; set; }

    public int? CozumOrtagiDosyaId { get; set; }

    public string? CompanyFiles { get; set; }

    public virtual ICollection<CozumOrtagiDosya> CozumOrtagiDosyas { get; set; } = new List<CozumOrtagiDosya>();

    public virtual ICollection<CustomerFastFile> CustomerFastFiles { get; set; } = new List<CustomerFastFile>();
}
