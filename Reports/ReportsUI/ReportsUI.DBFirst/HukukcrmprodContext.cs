using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReportsUI.DBFirst;

public partial class HukukcrmprodContext : DbContext
{
    public HukukcrmprodContext()
    {
    }

    public HukukcrmprodContext(DbContextOptions<HukukcrmprodContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AktivilerCevirus> AktivilerCeviris { get; set; }

    public virtual DbSet<AktiviteAction> AktiviteActions { get; set; }

    public virtual DbSet<AktiviteGelismeleri> AktiviteGelismeleris { get; set; }

    public virtual DbSet<AktiviteIhtimalleri> AktiviteIhtimalleris { get; set; }

    public virtual DbSet<AktiviteIhtimalleriArsiv> AktiviteIhtimalleriArsivs { get; set; }

    public virtual DbSet<AktiviteValidateParameter> AktiviteValidateParameters { get; set; }

    public virtual DbSet<AktiviteValidateType> AktiviteValidateTypes { get; set; }

    public virtual DbSet<Aktiviteler> Aktivitelers { get; set; }

    public virtual DbSet<AktivitelerBelgeKategori> AktivitelerBelgeKategoris { get; set; }

    public virtual DbSet<AktivitelerBelgeler> AktivitelerBelgelers { get; set; }

    public virtual DbSet<AktivitelerOdemeFatura> AktivitelerOdemeFaturas { get; set; }

    public virtual DbSet<Arsivfaturakaktivite> Arsivfaturakaktivites { get; set; }

    public virtual DbSet<AtananYetkiler> AtananYetkilers { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<BankaBilgileri> BankaBilgileris { get; set; }

    public virtual DbSet<CaseMessage> CaseMessages { get; set; }

    public virtual DbSet<CozumOrtagiAdre> CozumOrtagiAdres { get; set; }

    public virtual DbSet<CozumOrtagiBanka> CozumOrtagiBankas { get; set; }

    public virtual DbSet<CozumOrtagiDosya> CozumOrtagiDosyas { get; set; }

    public virtual DbSet<CozumOrtagiDosyaDavalar> CozumOrtagiDosyaDavalars { get; set; }

    public virtual DbSet<CozumOrtagiDosyaGelismeler> CozumOrtagiDosyaGelismelers { get; set; }

    public virtual DbSet<CozumOrtagiDosyaIcralar> CozumOrtagiDosyaIcralars { get; set; }

    public virtual DbSet<CozumOrtagiDosyaOdemeler> CozumOrtagiDosyaOdemelers { get; set; }

    public virtual DbSet<CozumOrtagiDosyaTaraflar> CozumOrtagiDosyaTaraflars { get; set; }

    public virtual DbSet<CozumOrtagiDosyaTeminatlar> CozumOrtagiDosyaTeminatlars { get; set; }

    public virtual DbSet<CozumOrtagiFaturalar> CozumOrtagiFaturalars { get; set; }

    public virtual DbSet<CozumOrtagiIletisim> CozumOrtagiIletisims { get; set; }

    public virtual DbSet<CozumOrtaklari> CozumOrtaklaris { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CustomerFastFile> CustomerFastFiles { get; set; }

    public virtual DbSet<CustomerFilePermission> CustomerFilePermissions { get; set; }

    public virtual DbSet<CustomerMailList> CustomerMailLists { get; set; }

    public virtual DbSet<CustomerPartner> CustomerPartners { get; set; }

    public virtual DbSet<DavaTipleri> DavaTipleris { get; set; }

    public virtual DbSet<DavaTurleri> DavaTurleris { get; set; }

    public virtual DbSet<DavaTurleriKategori> DavaTurleriKategoris { get; set; }

    public virtual DbSet<DavalarBelgeKategori> DavalarBelgeKategoris { get; set; }

    public virtual DbSet<DavalarBelgeler> DavalarBelgelers { get; set; }

    public virtual DbSet<Departmanlar> Departmanlars { get; set; }

    public virtual DbSet<DosyaDavaDurusmalar> DosyaDavaDurusmalars { get; set; }

    public virtual DbSet<DosyaDokumanlar> DosyaDokumanlars { get; set; }

    public virtual DbSet<DosyaDokumanlarVersionArsiv> DosyaDokumanlarVersionArsivs { get; set; }

    public virtual DbSet<DosyaDurumlar> DosyaDurumlars { get; set; }

    public virtual DbSet<DosyaKategoriler> DosyaKategorilers { get; set; }

    public virtual DbSet<DosyaTipleri> DosyaTipleris { get; set; }

    public virtual DbSet<DosyaYonetimGrubu> DosyaYonetimGrubus { get; set; }

    public virtual DbSet<Durumlar> Durumlars { get; set; }

    public virtual DbSet<EtkinlikTakvimi> EtkinlikTakvimis { get; set; }

    public virtual DbSet<Exception> Exceptions { get; set; }

    public virtual DbSet<FaizTanim> FaizTanims { get; set; }

    public virtual DbSet<FaturaNumarator> FaturaNumarators { get; set; }

    public virtual DbSet<FaturaTemp> FaturaTemps { get; set; }

    public virtual DbSet<FaturaTipleri> FaturaTipleris { get; set; }

    public virtual DbSet<Faturalar> Faturalars { get; set; }

    public virtual DbSet<FeedBack> FeedBacks { get; set; }

    public virtual DbSet<FileList> FileLists { get; set; }

    public virtual DbSet<FileRelationshipPbx> FileRelationshipPbxes { get; set; }

    public virtual DbSet<FileStatus> FileStatuses { get; set; }

    public virtual DbSet<FileType> FileTypes { get; set; }

    public virtual DbSet<FilesAuthorizeGroup> FilesAuthorizeGroups { get; set; }

    public virtual DbSet<FilesAuthorizeGroupMember> FilesAuthorizeGroupMembers { get; set; }

    public virtual DbSet<GetAktiviteListView> GetAktiviteListViews { get; set; }

    public virtual DbSet<GetClosedFileByAktiviteAll> GetClosedFileByAktiviteAlls { get; set; }

    public virtual DbSet<GetFilesAuthorizMember> GetFilesAuthorizMembers { get; set; }

    public virtual DbSet<GetGorevListView> GetGorevListViews { get; set; }

    public virtual DbSet<GetGorevListViewForAktiviteAktarim> GetGorevListViewForAktiviteAktarims { get; set; }

    public virtual DbSet<GetInvoiceList> GetInvoiceLists { get; set; }

    public virtual DbSet<GetInvoiceListDraft> GetInvoiceListDrafts { get; set; }

    public virtual DbSet<GetOpenFile> GetOpenFiles { get; set; }

    public virtual DbSet<GetTaraf> GetTarafs { get; set; }

    public virtual DbSet<HazirDokumanParametreleri> HazirDokumanParametreleris { get; set; }

    public virtual DbSet<HazirDokumanTipleri> HazirDokumanTipleris { get; set; }

    public virtual DbSet<HitMessage> HitMessages { get; set; }

    public virtual DbSet<IcraDavaDurusmalar> IcraDavaDurusmalars { get; set; }

    public virtual DbSet<IcraTakipTurleri> IcraTakipTurleris { get; set; }

    public virtual DbSet<IcralarBelgeKategori> IcralarBelgeKategoris { get; set; }

    public virtual DbSet<IcralarBelgeler> IcralarBelgelers { get; set; }

    public virtual DbSet<Il> Ils { get; set; }

    public virtual DbSet<Ilce> Ilces { get; set; }

    public virtual DbSet<InvoiceStatus> InvoiceStatuses { get; set; }

    public virtual DbSet<Kurlar> Kurlars { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<MahkemeIcra> MahkemeIcras { get; set; }

    public virtual DbSet<MahkemeTipleri> MahkemeTipleris { get; set; }

    public virtual DbSet<MailFormatlari> MailFormatlaris { get; set; }

    public virtual DbSet<MailLog> MailLogs { get; set; }

    public virtual DbSet<MainMenu> MainMenus { get; set; }

    public virtual DbSet<MhbHaraketTuru> MhbHaraketTurus { get; set; }

    public virtual DbSet<MuhasebeBatchFatura> MuhasebeBatchFaturas { get; set; }

    public virtual DbSet<MuhasebeDurumlar> MuhasebeDurumlars { get; set; }

    public virtual DbSet<MuhasebeGelirvegiderler> MuhasebeGelirvegiderlers { get; set; }

    public virtual DbSet<MuhasebeHareketleri> MuhasebeHareketleris { get; set; }

    public virtual DbSet<MuhasebeList> MuhasebeLists { get; set; }

    public virtual DbSet<MuhasebeMasrafAvan> MuhasebeMasrafAvans { get; set; }

    public virtual DbSet<MuhasebeMasrafAvansDetay> MuhasebeMasrafAvansDetays { get; set; }

    public virtual DbSet<Muhasebefatura> Muhasebefaturas { get; set; }

    public virtual DbSet<OdemeList> OdemeLists { get; set; }

    public virtual DbSet<OdemelerBelgeKategori> OdemelerBelgeKategoris { get; set; }

    public virtual DbSet<OdemelerBelgeler> OdemelerBelgelers { get; set; }

    public virtual DbSet<OtomatikAktiviteFonksiyonlari> OtomatikAktiviteFonksiyonlaris { get; set; }

    public virtual DbSet<OtomatikAktiviteler> OtomatikAktivitelers { get; set; }

    public virtual DbSet<ParaBirimi> ParaBirimis { get; set; }

    public virtual DbSet<PartnerParameter> PartnerParameters { get; set; }

    public virtual DbSet<PartnerPermission> PartnerPermissions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<Sayfa> Sayfas { get; set; }

    public virtual DbSet<Sektorler> Sektorlers { get; set; }

    public virtual DbSet<SubMenu> SubMenus { get; set; }

    public virtual DbSet<TarafAdre> TarafAdres { get; set; }

    public virtual DbSet<TarafBanka> TarafBankas { get; set; }

    public virtual DbSet<TarafIletisim> TarafIletisims { get; set; }

    public virtual DbSet<TarafReleation> TarafReleations { get; set; }

    public virtual DbSet<TarafSifatlari> TarafSifatlaris { get; set; }

    public virtual DbSet<Taraflar> Taraflars { get; set; }

    public virtual DbSet<Taraflist> Taraflists { get; set; }

    public virtual DbSet<TeminatDokumanlar> TeminatDokumanlars { get; set; }

    public virtual DbSet<TeminatKategoriler> TeminatKategorilers { get; set; }

    public virtual DbSet<TwoFactorLogin> TwoFactorLogins { get; set; }

    public virtual DbSet<Ulke> Ulkes { get; set; }

    public virtual DbSet<UlkeKodlari> UlkeKodlaris { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPermission> UserPermissions { get; set; }

    public virtual DbSet<UserPreference> UserPreferences { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UyeDurum> UyeDurums { get; set; }

    public virtual DbSet<UyeTarih> UyeTarihs { get; set; }

    public virtual DbSet<Uyeler> Uyelers { get; set; }

    public virtual DbSet<UyelerTur> UyelerTurs { get; set; }

    public virtual DbSet<VergiDaireleri> VergiDaireleris { get; set; }

    public virtual DbSet<VersionInfo> VersionInfos { get; set; }

    public virtual DbSet<ViewGetBorcluBilgiler> ViewGetBorcluBilgilers { get; set; }

    public virtual DbSet<VwIletisim> VwIletisims { get; set; }

    public virtual DbSet<Yetkiler> Yetkilers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=72.167.37.92; Database=HUKUKCRMPROD; User Id=ebec; Password=123456; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AktivilerCevirus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AktivilerCeviri");

            entity.Property(e => e.En)
                .HasMaxLength(255)
                .HasColumnName("EN");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ihtimal)
                .HasMaxLength(255)
                .HasColumnName("ihtimal");
        });

        modelBuilder.Entity<AktiviteAction>(entity =>
        {
            entity.ToTable("Aktivite_Action");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AktiviteGelismeleri>(entity =>
        {
            entity.ToTable("aktivite_gelismeleri");

            entity.HasIndex(e => e.OlusturulmaTarihi, "NonClusteredIndex-20220429-145553");

            entity.HasIndex(e => new { e.GelismeId, e.AktivitelerId }, "NonClusteredIndex-20220429-145604");

            entity.HasIndex(e => new { e.AktivitelerId, e.Iscompleted, e.Id }, "_dta_index_aktivite_gelismeleri_5_1477580302__K11_K9_K1_5").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AktiviteId).HasColumnName("aktivite_id");
            entity.Property(e => e.AktivitelerId).HasColumnName("Aktiviteler_id");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.Faturaid).HasColumnName("faturaid");
            entity.Property(e => e.GelismeId).HasColumnName("gelisme_id");
            entity.Property(e => e.GelismeNotu).HasColumnName("gelisme_notu");
            entity.Property(e => e.Gorevliler)
                .HasMaxLength(50)
                .HasColumnName("gorevliler");
            entity.Property(e => e.IhtimalId).HasColumnName("ihtimal_id");
            entity.Property(e => e.IsCustomer).HasColumnName("isCustomer");
            entity.Property(e => e.Iscompleted).HasColumnName("iscompleted");
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
        });

        modelBuilder.Entity<AktiviteIhtimalleri>(entity =>
        {
            entity.ToTable("aktivite_ihtimalleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.Gorevliler)
                .HasMaxLength(50)
                .HasColumnName("gorevliler");
            entity.Property(e => e.Ihtimal)
                .HasMaxLength(250)
                .HasColumnName("ihtimal");
            entity.Property(e => e.IhtimalEn)
                .HasMaxLength(250)
                .HasColumnName("ihtimalEN");
            entity.Property(e => e.Invoiceid).HasColumnName("invoiceid");
            entity.Property(e => e.IsAction)
                .HasDefaultValueSql("((1))")
                .HasColumnName("isAction");
            entity.Property(e => e.IsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isMain");
            entity.Property(e => e.IsPayed).HasColumnName("isPayed");
            entity.Property(e => e.IsValidateType)
                .HasDefaultValueSql("((1))")
                .HasColumnName("isValidateType");
            entity.Property(e => e.Isdelete)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isdelete");
        });

        modelBuilder.Entity<AktiviteIhtimalleriArsiv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("aktivite_ihtimalleri_Arsiv");

            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.Gorevliler)
                .HasMaxLength(50)
                .HasColumnName("gorevliler");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Ihtimal)
                .HasMaxLength(250)
                .HasColumnName("ihtimal");
            entity.Property(e => e.IsValidateType).HasColumnName("isValidateType");
        });

        modelBuilder.Entity<AktiviteValidateParameter>(entity =>
        {
            entity.ToTable("Aktivite_ValidateParameters");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ValideName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AktiviteValidateType>(entity =>
        {
            entity.ToTable("Aktivite_ValidateTypes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Aktiviteler>(entity =>
        {
            entity.ToTable("aktiviteler");

            entity.HasIndex(e => e.AktiviteAdi, "NonClusteredIndex-20220429-145525");

            entity.HasIndex(e => e.OlusturulmaTarihi, "NonClusteredIndex-20220429-145534");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AktiviteAdi)
                .HasMaxLength(250)
                .HasColumnName("aktivite_adi");
            entity.Property(e => e.AktiviteIhtimali).HasColumnName("aktivite_ihtimali");
            entity.Property(e => e.AktiviteNotu).HasColumnName("aktivite_notu");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.Durum)
                .HasMaxLength(250)
                .HasColumnName("durum");
            entity.Property(e => e.FaturaId).HasColumnName("fatura_id");
            entity.Property(e => e.Gorevliler)
                .HasMaxLength(250)
                .HasColumnName("gorevliler");
            entity.Property(e => e.IsCustomer).HasColumnName("isCustomer");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.IsWait)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isWait");
            entity.Property(e => e.OdemeId).HasColumnName("odeme_id");
            entity.Property(e => e.OdemeParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("odeme_para_birimi");
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
            entity.Property(e => e.SonTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("son_tarihi");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Yetkigrubu)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AktivitelerBelgeKategori>(entity =>
        {
            entity.ToTable("aktiviteler_belge_kategori");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.Kategori)
                .HasMaxLength(250)
                .HasColumnName("kategori");
        });

        modelBuilder.Entity<AktivitelerBelgeler>(entity =>
        {
            entity.ToTable("aktiviteler_belgeler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dokuman).HasColumnName("dokuman");
            entity.Property(e => e.DokumanAdi).HasColumnName("dokuman_adi");
            entity.Property(e => e.KategoriId).HasColumnName("kategori_id");
            entity.Property(e => e.Klasor).HasColumnName("klasor");
        });

        modelBuilder.Entity<AktivitelerOdemeFatura>(entity =>
        {
            entity.ToTable("aktiviteler_odeme_fatura");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AktiviteId).HasColumnName("aktivite_id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.OdemeId).HasColumnName("odeme_id");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tutar");
        });

        modelBuilder.Entity<Arsivfaturakaktivite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("arsivfaturakaktivite");

            entity.Property(e => e.Aktiviteid).HasColumnName("aktiviteid");
            entity.Property(e => e.FaturaId).HasColumnName("fatura_id");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<AtananYetkiler>(entity =>
        {
            entity.ToTable("atanan_yetkiler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DepartmanId).HasColumnName("departman_id");
            entity.Property(e => e.YetkiId).HasColumnName("yetki_id");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.ToTable("AuditLog");

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChangedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Changes).IsUnicode(false);
            entity.Property(e => e.Module)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Page)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BankaBilgileri>(entity =>
        {
            entity.ToTable("banka_bilgileri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankaAdi)
                .HasMaxLength(250)
                .HasColumnName("banka_adi");
            entity.Property(e => e.HesapAdi).HasMaxLength(250);
            entity.Property(e => e.HesapNumarasi)
                .HasMaxLength(250)
                .HasColumnName("hesap_numarasi");
            entity.Property(e => e.HesapSahibi)
                .HasMaxLength(250)
                .HasColumnName("hesap_sahibi");
            entity.Property(e => e.IbanNumarasi)
                .HasMaxLength(250)
                .HasColumnName("iban_numarasi");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(250)
                .HasColumnName("para_birimi");
            entity.Property(e => e.RoutingNumber).HasMaxLength(205);
            entity.Property(e => e.SubeAdi).HasMaxLength(205);
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(250)
                .HasColumnName("sube_kodu");
            entity.Property(e => e.SwiftKodu)
                .HasMaxLength(250)
                .HasColumnName("swift_kodu");
        });

        modelBuilder.Entity<CaseMessage>(entity =>
        {
            entity.ToTable("CaseMessage");

            entity.Property(e => e.IsRead).HasColumnName("isRead");
            entity.Property(e => e.Username).HasMaxLength(150);
        });

        modelBuilder.Entity<CozumOrtagiAdre>(entity =>
        {
            entity.ToTable("cozum_ortagi_adres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Adres)
                .HasMaxLength(350)
                .HasColumnName("adres");
            entity.Property(e => e.AdresBasligi)
                .HasMaxLength(250)
                .HasColumnName("adres_basligi");
            entity.Property(e => e.Birincil)
                .HasMaxLength(10)
                .HasColumnName("birincil");
            entity.Property(e => e.CozumortagiId).HasColumnName("cozumortagi_id");
            entity.Property(e => e.EklenmeTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("eklenme_tarihi");
            entity.Property(e => e.Ekleyen)
                .HasMaxLength(250)
                .HasColumnName("ekleyen");
            entity.Property(e => e.Ilce)
                .HasMaxLength(100)
                .HasColumnName("ilce");
            entity.Property(e => e.KayitTipi).HasMaxLength(330);
            entity.Property(e => e.PostaKodu)
                .HasMaxLength(50)
                .HasColumnName("posta_kodu");
            entity.Property(e => e.Sehir)
                .HasMaxLength(100)
                .HasColumnName("sehir");
            entity.Property(e => e.Ulke)
                .HasMaxLength(100)
                .HasColumnName("ulke");
        });

        modelBuilder.Entity<CozumOrtagiBanka>(entity =>
        {
            entity.ToTable("cozum_ortagi_banka");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.BankaAdi)
                .HasMaxLength(250)
                .HasColumnName("banka_adi");
            entity.Property(e => e.Birincil)
                .HasMaxLength(10)
                .HasColumnName("birincil");
            entity.Property(e => e.CozumortagiId).HasColumnName("cozumortagi_id");
            entity.Property(e => e.Currency).HasMaxLength(250);
            entity.Property(e => e.EklenmeTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("eklenme_tarihi");
            entity.Property(e => e.Ekleyen).HasMaxLength(250);
            entity.Property(e => e.HesapNumarasi)
                .HasMaxLength(250)
                .HasColumnName("hesap_numarasi");
            entity.Property(e => e.HesapSahibi)
                .HasMaxLength(250)
                .HasColumnName("hesap_sahibi");
            entity.Property(e => e.Hesapadi)
                .HasMaxLength(250)
                .HasColumnName("hesapadi");
            entity.Property(e => e.IbanNumarasi)
                .HasMaxLength(250)
                .HasColumnName("iban_numarasi");
            entity.Property(e => e.KayitTipi).HasMaxLength(250);
            entity.Property(e => e.RoutingName).HasMaxLength(250);
            entity.Property(e => e.SubeAdi).HasMaxLength(250);
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(250)
                .HasColumnName("sube_kodu");
            entity.Property(e => e.SwiftKodu)
                .HasMaxLength(250)
                .HasColumnName("swift_kodu");
        });

        modelBuilder.Entity<CozumOrtagiDosya>(entity =>
        {
            entity.ToTable("cozum_ortagi_dosya");

            entity.HasIndex(e => e.DosyaNo, "UQ_dosya_no").IsUnique();

            entity.HasIndex(e => new { e.DosyaAdi, e.CozumortagiId, e.ParaBirimi, e.DosyaNo, e.Id }, "cozum_ortagi_dosya_v1").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Asilalacaktutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("asilalacaktutari");
            entity.Property(e => e.BorcTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("borc_tutari");
            entity.Property(e => e.Collectionbankaid).HasColumnName("collectionbankaid");
            entity.Property(e => e.CozumortagiId).HasColumnName("cozumortagi_id");
            entity.Property(e => e.CozumortagidosyaNo)
                .HasMaxLength(250)
                .HasColumnName("cozumortagidosya_no");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerFileMessageStatusValue).HasMaxLength(800);
            entity.Property(e => e.CustomerFileMessageType).HasMaxLength(800);
            entity.Property(e => e.DigerVergi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("diger_vergi");
            entity.Property(e => e.DosyaAdi)
                .HasMaxLength(250)
                .HasColumnName("dosya_adi");
            entity.Property(e => e.DosyaDurumu)
                .HasMaxLength(200)
                .HasColumnName("dosya_durumu");
            entity.Property(e => e.DosyaNo)
                .HasMaxLength(250)
                .HasColumnName("dosya_no");
            entity.Property(e => e.Dosyaislem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Faiz)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("faiz");
            entity.Property(e => e.FileStatusId).HasColumnName("FileStatusID");
            entity.Property(e => e.GenelBilgi).HasColumnName("genel_bilgi");
            entity.Property(e => e.Gorevliler)
                .HasMaxLength(250)
                .HasColumnName("gorevliler");
            entity.Property(e => e.GuncellenmeTarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("guncellenme_tarih");
            entity.Property(e => e.GuncelleyenPersonel).HasColumnName("guncelleyen_personel");
            entity.Property(e => e.Invoicebankaid).HasColumnName("invoicebankaid");
            entity.Property(e => e.KalanBorcTutari)
                .HasMaxLength(220)
                .IsUnicode(false);
            entity.Property(e => e.KapatmaTarihi).HasColumnType("smalldatetime");
            entity.Property(e => e.Kdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kdv");
            entity.Property(e => e.Komisyon)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("komisyon");
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
            entity.Property(e => e.PartnersClaimNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartnersClientClaimNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartnersClientNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartnersCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PartnersInterestAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Cozumortagi).WithMany(p => p.CozumOrtagiDosyas)
                .HasForeignKey(d => d.CozumortagiId)
                .HasConstraintName("FK_cozumortagi_id");
        });

        modelBuilder.Entity<CozumOrtagiDosyaDavalar>(entity =>
        {
            entity.ToTable("cozum_ortagi_dosya_davalar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasMaxLength(250);
            entity.Property(e => e.AlacakliAdi).HasMaxLength(250);
            entity.Property(e => e.BorcluAdi).HasMaxLength(250);
            entity.Property(e => e.DavaDegeri)
                .HasMaxLength(50)
                .HasColumnName("dava_degeri");
            entity.Property(e => e.DavaDosyaEsasNo).HasColumnName("dava_dosya_esas_no");
            entity.Property(e => e.DavaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("dava_tarihi");
            entity.Property(e => e.DavaTuru).HasColumnName("dava_turu");
            entity.Property(e => e.DosyaAdi).HasMaxLength(250);
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.DosyaKararNo).HasColumnName("dosya_karar_no");
            entity.Property(e => e.DurusmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("durusma_tarihi");
            entity.Property(e => e.IcraDairesiId).HasColumnName("IcraDairesiID");
            entity.Property(e => e.Mahkeme).HasColumnName("mahkeme");
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
            entity.Property(e => e.TakipTuruId).HasColumnName("TakipTuruID");
        });

        modelBuilder.Entity<CozumOrtagiDosyaGelismeler>(entity =>
        {
            entity.ToTable("cozum_ortagi_dosya_gelismeler");

            entity.HasIndex(e => new { e.GelismeTarihi, e.OlusturmaTarihi }, "NonClusteredIndex-20220429-142624");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.GelismeNotu).HasColumnName("gelisme_notu");
            entity.Property(e => e.GelismeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("gelisme_tarihi");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(450)
                .HasColumnName("guncelleme_tarihi");
            entity.Property(e => e.GuncelleyenPersonel).HasColumnName("guncelleyen_personel");
            entity.Property(e => e.IsCustomer).HasColumnName("isCustomer");
            entity.Property(e => e.IsHtml).HasColumnName("isHtml");
            entity.Property(e => e.IsPayedDate).HasColumnName("isPayedDate");
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturmaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("olusturma_tarihi");

            entity.HasOne(d => d.Dosya).WithMany(p => p.CozumOrtagiDosyaGelismelers)
                .HasForeignKey(d => d.DosyaId)
                .HasConstraintName("FK_dosya_gelismeler");
        });

        modelBuilder.Entity<CozumOrtagiDosyaIcralar>(entity =>
        {
            entity.ToTable("cozum_ortagi_dosya_icralar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlacakliAdi).HasMaxLength(250);
            entity.Property(e => e.BorcluAdi).HasMaxLength(250);
            entity.Property(e => e.DosyaAdi).HasMaxLength(250);
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.IcraDairesi).HasColumnName("icra_dairesi");
            entity.Property(e => e.IcraDairesiId).HasColumnName("IcraDairesiID");
            entity.Property(e => e.IcraTakipEsasNo).HasColumnName("icra_takip_esas_no");
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("para_birimi");
            entity.Property(e => e.TakipTarihi).HasColumnName("takip_tarihi");
            entity.Property(e => e.TakipTuru).HasColumnName("takip_turu");
            entity.Property(e => e.TakipTuruId).HasColumnName("TakipTuruID");
            entity.Property(e => e.TakipTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("takip_tutari");
        });

        modelBuilder.Entity<CozumOrtagiDosyaOdemeler>(entity =>
        {
            entity.ToTable("cozum_ortagi_dosya_odemeler");

            entity.HasIndex(e => new { e.Id, e.IsPayedDate, e.BankaTipi, e.OdemeTutari, e.ParaBirimi }, "cozum_ortagi_dosya_odemeler_v1").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.DovizKuru).HasMaxLength(50);
            entity.Property(e => e.ExChangeNetTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FaturaTutari).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Faturaid).HasColumnName("faturaid");
            entity.Property(e => e.GuncellemeTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsCustomer).HasColumnName("isCustomer");
            entity.Property(e => e.IsDelete)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDelete");
            entity.Property(e => e.IsInvoice).HasColumnName("isInvoice");
            entity.Property(e => e.IsNotProgress).HasColumnName("isNotProgress");
            entity.Property(e => e.IsPayedDate).HasColumnName("isPayedDate");
            entity.Property(e => e.KayitTarihi).HasColumnType("smalldatetime");
            entity.Property(e => e.KurTarihi).HasColumnType("datetime");
            entity.Property(e => e.KurTutariTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KurTutariTL");
            entity.Property(e => e.Kurdegeri).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OdemeTipi).HasMaxLength(250);
            entity.Property(e => e.OdemeTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("odeme_tutari");
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.Onay)
                .HasMaxLength(250)
                .HasColumnName("onay");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
            entity.Property(e => e.TahsilatTarihi)
                .HasColumnType("datetime")
                .HasColumnName("tahsilat_tarihi");

            entity.HasOne(d => d.Dosya).WithMany(p => p.CozumOrtagiDosyaOdemelers)
                .HasForeignKey(d => d.DosyaId)
                .HasConstraintName("FK_Dosya_Odeme");
        });

        modelBuilder.Entity<CozumOrtagiDosyaTaraflar>(entity =>
        {
            entity.ToTable("cozum_ortagi_dosya_taraflar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.SifatId).HasColumnName("SifatID");
            entity.Property(e => e.TarafId).HasColumnName("taraf_id");
            entity.Property(e => e.TarafSifati)
                .HasMaxLength(250)
                .HasColumnName("taraf_sifati");
        });

        modelBuilder.Entity<CozumOrtagiDosyaTeminatlar>(entity =>
        {
            entity.ToTable("cozum_ortagi_dosya_teminatlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.GuncellemeTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("guncelleme_tarihi");
            entity.Property(e => e.GuncelleyenPersonel).HasColumnName("guncelleyen_personel");
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
            entity.Property(e => e.Teminat)
                .HasMaxLength(250)
                .HasColumnName("teminat");
            entity.Property(e => e.TeminatNotu).HasColumnName("teminat_notu");
        });

        modelBuilder.Entity<CozumOrtagiFaturalar>(entity =>
        {
            entity.ToTable("cozum_ortagi_faturalar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.OdemeId).HasColumnName("odeme_id");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tutar");
        });

        modelBuilder.Entity<CozumOrtagiIletisim>(entity =>
        {
            entity.ToTable("cozum_ortagi_iletisim");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Birincil)
                .HasMaxLength(10)
                .HasColumnName("birincil");
            entity.Property(e => e.CozumortagiId).HasColumnName("cozumortagi_id");
            entity.Property(e => e.EklenmeTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("eklenme_tarihi");
            entity.Property(e => e.EmailAdresi)
                .HasMaxLength(250)
                .HasColumnName("email_adresi");
            entity.Property(e => e.FaksNumarasi)
                .HasMaxLength(25)
                .HasColumnName("faks_numarasi");
            entity.Property(e => e.GsmNumarasi)
                .HasMaxLength(25)
                .HasColumnName("gsm_numarasi");
            entity.Property(e => e.GunceleyenKullanici).HasMaxLength(250);
            entity.Property(e => e.SabitTelefon)
                .HasMaxLength(25)
                .HasColumnName("sabit_telefon");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.WebSitesi)
                .HasMaxLength(250)
                .HasColumnName("web_sitesi");
        });

        modelBuilder.Entity<CozumOrtaklari>(entity =>
        {
            entity.ToTable("cozum_ortaklari");

            entity.HasIndex(e => new { e.Id, e.CozumortagiAdi }, "cozum_ortaklari_v1").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ailesirano).HasMaxLength(150);
            entity.Property(e => e.Babaadi).HasMaxLength(150);
            entity.Property(e => e.CozumOrtagiDosyaId).HasColumnName("Cozum_ortagi_dosya_id");
            entity.Property(e => e.CozumortagiAdi)
                .HasMaxLength(100)
                .HasColumnName("cozumortagi_adi");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DogumYeri)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuncellemePersonel).HasColumnName("guncelleme_personel");
            entity.Property(e => e.GuncellemeTarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("guncelleme_tarih");
            entity.Property(e => e.Ilce)
                .HasMaxLength(150)
                .HasColumnName("ilce");
            entity.Property(e => e.IlgiliPersonel).HasColumnName("ilgili_personel");
            entity.Property(e => e.Nufuskayityeri).HasMaxLength(150);
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
            entity.Property(e => e.PartnerGuid).HasMaxLength(100);
            entity.Property(e => e.Sehir).HasMaxLength(150);
            entity.Property(e => e.Sektor)
                .HasMaxLength(250)
                .HasColumnName("sektor");
            entity.Property(e => e.Serino).HasMaxLength(150);
            entity.Property(e => e.Sirano).HasMaxLength(150);
            entity.Property(e => e.Taraf)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TarafNormalize)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TarafYetkiliAdSoyad)
                .HasMaxLength(250)
                .HasColumnName("Taraf_Yetkili_AdSoyad");
            entity.Property(e => e.Taraftipi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("taraftipi");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TicariUnvan)
                .HasMaxLength(250)
                .HasColumnName("ticari_unvan");
            entity.Property(e => e.Uyruk).HasMaxLength(150);
            entity.Property(e => e.VergiDairesi)
                .HasMaxLength(250)
                .HasColumnName("vergi_dairesi");
            entity.Property(e => e.VergiNumarasi)
                .HasMaxLength(50)
                .HasColumnName("vergi_numarasi");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Currency__3213E83F12F02949");

            entity.ToTable("Currency");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BanknoteBuying).HasMaxLength(250);
            entity.Property(e => e.BanknoteSelling).HasMaxLength(250);
            entity.Property(e => e.BultenNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Bulten_No");
            entity.Property(e => e.CrossOrder).HasMaxLength(250);
            entity.Property(e => e.CrossRateOther).HasMaxLength(250);
            entity.Property(e => e.CrossRateUsd)
                .HasMaxLength(250)
                .HasColumnName("CrossRateUSD");
            entity.Property(e => e.CurrencyCode).HasMaxLength(250);
            entity.Property(e => e.CurrencyName).HasMaxLength(250);
            entity.Property(e => e.Ddate)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ForexBuying).HasMaxLength(250);
            entity.Property(e => e.ForexSelling).HasMaxLength(250);
            entity.Property(e => e.Isim).HasMaxLength(250);
            entity.Property(e => e.Kod).HasMaxLength(250);
            entity.Property(e => e.Tarih).HasMaxLength(250);
            entity.Property(e => e.Unit).HasMaxLength(250);
        });

        modelBuilder.Entity<CustomerFastFile>(entity =>
        {
            entity.ToTable("CustomerFastFile");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApprovalptDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CustomerFileNumber).HasMaxLength(250);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DebtAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.FileNumber).HasMaxLength(250);
            entity.Property(e => e.FileStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.Interest).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivableAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Currency).WithMany(p => p.CustomerFastFiles)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("FK_CustomerFastFile_Currency");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerFastFiles)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomerImportFileCreate_Customer");

            entity.HasOne(d => d.FileStatusNavigation).WithMany(p => p.CustomerFastFiles)
                .HasForeignKey(d => d.FileStatus)
                .HasConstraintName("FK_CustomerImportFileCreate_FileStatus");

            entity.HasOne(d => d.FileTypes).WithMany(p => p.CustomerFastFiles)
                .HasForeignKey(d => d.FileTypesId)
                .HasConstraintName("FK_CustomerFastFile_FileType");
        });

        modelBuilder.Entity<CustomerFilePermission>(entity =>
        {
            entity.ToTable("CustomerFilePermission");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustomerFileId).HasColumnName("CustomerFileID");
        });

        modelBuilder.Entity<CustomerMailList>(entity =>
        {
            entity.ToTable("CustomerMailList");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cc).HasColumnName("CC");
            entity.Property(e => e.KayitTarihi).HasColumnType("datetime");
            entity.Property(e => e.MailAdresi).HasMaxLength(200);
        });

        modelBuilder.Entity<CustomerPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Suppliers");

            entity.ToTable("CustomerPartner");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.ContactTitle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.Guid).HasMaxLength(100);
            entity.Property(e => e.IdentificationNo).HasMaxLength(30);
            entity.Property(e => e.Normalize).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.TaxNumber).HasMaxLength(30);
        });

        modelBuilder.Entity<DavaTipleri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DavaTipl__3213E83FF6B0FED8");

            entity.ToTable("DavaTipleri");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<DavaTurleri>(entity =>
        {
            entity.ToTable("dava_turleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.DavaTuru).HasColumnName("dava_turu");
        });

        modelBuilder.Entity<DavaTurleriKategori>(entity =>
        {
            entity.ToTable("dava_turleri_kategori");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DavaKategori).HasColumnName("dava_kategori");
        });

        modelBuilder.Entity<DavalarBelgeKategori>(entity =>
        {
            entity.ToTable("davalar_belge_kategori");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.Kategori)
                .HasMaxLength(250)
                .HasColumnName("kategori");
        });

        modelBuilder.Entity<DavalarBelgeler>(entity =>
        {
            entity.ToTable("davalar_belgeler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dokuman).HasColumnName("dokuman");
            entity.Property(e => e.DokumanAdi).HasColumnName("dokuman_adi");
            entity.Property(e => e.KategoriId).HasColumnName("kategori_id");
            entity.Property(e => e.Klasor).HasColumnName("klasor");
        });

        modelBuilder.Entity<Departmanlar>(entity =>
        {
            entity.ToTable("departmanlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DepartmanAdi)
                .HasMaxLength(50)
                .HasColumnName("departman_adi");
        });

        modelBuilder.Entity<DosyaDavaDurusmalar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DosyaDav__3213E83F7A67FEBB");

            entity.ToTable("DosyaDavaDurusmalar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DavaAdi)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Dokumanadi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("dokumanadi");
            entity.Property(e => e.DurusmaTipi).HasMaxLength(50);
        });

        modelBuilder.Entity<DosyaDokumanlar>(entity =>
        {
            entity.ToTable("dosya_dokumanlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArsivYolu).HasMaxLength(500);
            entity.Property(e => e.Departman).HasMaxLength(50);
            entity.Property(e => e.DokumanAdi).HasColumnName("dokuman_adi");
            entity.Property(e => e.DosyaTipi)
                .HasMaxLength(2)
                .HasDefaultValueSql("('D')")
                .IsFixedLength();
            entity.Property(e => e.Dosyauzantisi).HasMaxLength(5);
            entity.Property(e => e.IsUpdate).HasColumnName("isUpdate");
        });

        modelBuilder.Entity<DosyaDokumanlarVersionArsiv>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dosya_Do__3213E83FBA4D66D8");

            entity.ToTable("Dosya_DokumanlarVersionArsiv");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArsivYolu).HasMaxLength(500);
            entity.Property(e => e.Departman).HasMaxLength(500);
            entity.Property(e => e.DokumanAdi).HasMaxLength(250);
            entity.Property(e => e.DosyaGuid).HasMaxLength(100);
            entity.Property(e => e.Dosyauzantisi).HasMaxLength(100);
        });

        modelBuilder.Entity<DosyaDurumlar>(entity =>
        {
            entity.ToTable("dosya_durumlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DurumAdi)
                .HasMaxLength(250)
                .HasColumnName("durum_adi");
            entity.Property(e => e.IsCustomer)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isCustomer");
            entity.Property(e => e.NameEn)
                .HasMaxLength(250)
                .HasColumnName("NameEN");
            entity.Property(e => e.PermissionGroup).HasMaxLength(250);
        });

        modelBuilder.Entity<DosyaKategoriler>(entity =>
        {
            entity.ToTable("dosya_kategoriler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaAdi)
                .HasMaxLength(250)
                .HasColumnName("dosya_adi");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.Kategori)
                .HasMaxLength(250)
                .HasColumnName("kategori");
        });

        modelBuilder.Entity<DosyaTipleri>(entity =>
        {
            entity.ToTable("dosya_tipleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaTipi).HasColumnName("dosya_tipi");
        });

        modelBuilder.Entity<DosyaYonetimGrubu>(entity =>
        {
            entity.ToTable("DosyaYonetimGrubu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GrupName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Durumlar>(entity =>
        {
            entity.ToTable("durumlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DurumAdi)
                .HasMaxLength(50)
                .HasColumnName("durum_adi");
        });

        modelBuilder.Entity<EtkinlikTakvimi>(entity =>
        {
            entity.ToTable("etkinlik_takvimi");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("aciklama");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .HasColumnName("className");
            entity.Property(e => e.Detay).HasColumnName("detay");
            entity.Property(e => e.EtkinlikTipi).HasMaxLength(150);
            entity.Property(e => e.NormalizeDate).HasColumnType("date");
            entity.Property(e => e.StartDate)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Exception>(entity =>
        {
            entity.Property(e => e.ApplicationName).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DeletionDate).HasColumnType("datetime");
            entity.Property(e => e.DuplicateCount).HasDefaultValueSql("((1))");
            entity.Property(e => e.Guid).HasColumnName("GUID");
            entity.Property(e => e.Host).HasMaxLength(100);
            entity.Property(e => e.Httpmethod)
                .HasMaxLength(10)
                .HasColumnName("HTTPMethod");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(40)
                .HasColumnName("IPAddress");
            entity.Property(e => e.IsProtected)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.MachineName).HasMaxLength(50);
            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.Sql).HasColumnName("SQL");
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.Url).HasMaxLength(500);
        });

        modelBuilder.Entity<FaizTanim>(entity =>
        {
            entity.ToTable("FaizTanim");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<FaturaNumarator>(entity =>
        {
            entity.ToTable("FaturaNumarator");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Tarih).HasMaxLength(50);
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<FaturaTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FaturaTemp");

            entity.Property(e => e.Banka).HasMaxLength(255);
            entity.Property(e => e.Borclu)
                .HasMaxLength(255)
                .HasColumnName("borclu");
            entity.Property(e => e.Durumu).HasMaxLength(255);
            entity.Property(e => e.FaturaNo).HasMaxLength(255);
            entity.Property(e => e.FaturaTipi)
                .HasMaxLength(255)
                .HasColumnName("Fatura Tipi");
            entity.Property(e => e.FaturaTutari).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KTarihi)
                .HasColumnType("datetime")
                .HasColumnName("K#Tarihi");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(255)
                .HasColumnName("Para Birimi");
            entity.Property(e => e.TParaBirimi)
                .HasMaxLength(255)
                .HasColumnName("T#Para Birimi");
            entity.Property(e => e.TahsilatTutarı)
                .HasMaxLength(255)
                .HasColumnName("Tahsilat Tutarı");
            entity.Property(e => e.Taraf).HasMaxLength(255);
            entity.Property(e => e.İlgiliDosya).HasColumnName("İlgili Dosya");
            entity.Property(e => e.İşlem).HasMaxLength(255);
        });

        modelBuilder.Entity<FaturaTipleri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FaturaTi__3213E83F82A75CC1");

            entity.ToTable("FaturaTipleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AktiviteId).HasColumnName("AktiviteID");
            entity.Property(e => e.FaturaDurumuId).HasColumnName("FaturaDurumuID");
            entity.Property(e => e.FaturaTipi)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.IsArsivFileView).HasColumnName("isArsivFileView");
            entity.Property(e => e.IsBatchClose).HasColumnName("isBatchClose");
            entity.Property(e => e.IsMasraf).HasColumnName("isMasraf");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tutar).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Faturalar>(entity =>
        {
            entity.ToTable("Faturalar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FaturaNo).HasMaxLength(50);
            entity.Property(e => e.FaturaTarihi)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OdemeBankası).HasMaxLength(250);
            entity.Property(e => e.Taraf).HasMaxLength(250);
            entity.Property(e => e.TarafAdres).HasMaxLength(250);
            entity.Property(e => e.TarafMail).HasMaxLength(250);
            entity.Property(e => e.Tutar).HasMaxLength(50);
        });

        modelBuilder.Entity<FeedBack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FeedBack__3213E83FE1BFB901");

            entity.ToTable("FeedBack");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).IsUnicode(false);
            entity.Property(e => e.Adres)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Baslik)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Durumu)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FileList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileList");

            entity.Property(e => e.Dosyaadi)
                .HasMaxLength(250)
                .HasColumnName("dosyaadi");
            entity.Property(e => e.Dosyano)
                .HasMaxLength(250)
                .HasColumnName("dosyano");
            entity.Property(e => e.Durum).HasMaxLength(250);
            entity.Property(e => e.Kullanici).HasMaxLength(50);
            entity.Property(e => e.Kurumdosya)
                .HasMaxLength(250)
                .HasColumnName("kurumdosya");
            entity.Property(e => e.Yetkigrubu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("yetkigrubu");
        });

        modelBuilder.Entity<FileRelationshipPbx>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FileRela__3214EC070A6F9B40");

            entity.ToTable("FileRelationshipPBX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CallDate).HasMaxLength(250);
            entity.Property(e => e.CallId).HasMaxLength(250);
            entity.Property(e => e.CallNumber).HasMaxLength(250);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.InternalNumber).HasMaxLength(250);
            entity.Property(e => e.SoundPath).HasMaxLength(250);
        });

        modelBuilder.Entity<FileStatus>(entity =>
        {
            entity.ToTable("FileStatus");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(70);
        });

        modelBuilder.Entity<FileType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FileType__3214EC27EEB6D443");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("isActive");
            entity.Property(e => e.IsClient).HasColumnName("isClient");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<FilesAuthorizeGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FilesAut__3213E83FEA8A6B7C");

            entity.ToTable("FilesAuthorizeGroup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorizeName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("isActive");
        });

        modelBuilder.Entity<FilesAuthorizeGroupMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FilesAut__3213E83FDC0613B8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Membersid)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GetAktiviteListView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetAktiviteListView");

            entity.Property(e => e.AktiviteAdi)
                .HasMaxLength(250)
                .HasColumnName("aktivite_adi");
            entity.Property(e => e.DosyaAdi)
                .HasMaxLength(250)
                .HasColumnName("dosya_adi");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.Durum)
                .HasMaxLength(250)
                .HasColumnName("durum");
            entity.Property(e => e.GelismeId).HasColumnName("gelisme_id");
            entity.Property(e => e.Gorevliler)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("gorevliler");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ihtimal)
                .HasMaxLength(250)
                .HasColumnName("ihtimal");
            entity.Property(e => e.OlusturanPersonel)
                .HasMaxLength(101)
                .HasColumnName("olusturan_personel");
            entity.Property(e => e.SonTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("son_tarihi");
        });

        modelBuilder.Entity<GetClosedFileByAktiviteAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetClosedFileByAktiviteAll");

            entity.Property(e => e.AktiviteAdi).HasMaxLength(250);
            entity.Property(e => e.AktiviteDurum).HasMaxLength(250);
            entity.Property(e => e.DosyaAdi).HasMaxLength(250);
            entity.Property(e => e.DosyaDurum).HasMaxLength(250);
            entity.Property(e => e.DosyaNo).HasMaxLength(250);
        });

        modelBuilder.Entity<GetFilesAuthorizMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetFilesAuthorizMembers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MemberListesi)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.YetkiGrubu)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GetGorevListView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetGorevListView");

            entity.Property(e => e.Aktivite)
                .HasMaxLength(250)
                .HasColumnName("aktivite");
            entity.Property(e => e.DosyaAdi)
                .HasMaxLength(250)
                .HasColumnName("dosya_adi");
            entity.Property(e => e.DosyaNo).HasMaxLength(250);
            entity.Property(e => e.DosyaTipi).HasColumnName("dosya_tipi");
            entity.Property(e => e.Dosyaid).HasColumnName("dosyaid");
            entity.Property(e => e.Durum)
                .HasMaxLength(250)
                .HasColumnName("durum");
            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.Gorevliler)
                .HasMaxLength(50)
                .HasColumnName("gorevliler");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ihtimal)
                .HasMaxLength(250)
                .HasColumnName("ihtimal");
            entity.Property(e => e.Iscompleted).HasColumnName("iscompleted");
            entity.Property(e => e.Taraf).HasMaxLength(100);
        });

        modelBuilder.Entity<GetGorevListViewForAktiviteAktarim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetGorevListViewForAktiviteAktarim");

            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.Gorevliler)
                .HasMaxLength(50)
                .HasColumnName("gorevliler");
        });

        modelBuilder.Entity<GetInvoiceList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetInvoiceList");

            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.BacthInvoiceId)
                .HasMaxLength(250)
                .HasColumnName("BacthInvoiceID");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BorcluId).HasColumnName("Borclu_id");
            entity.Property(e => e.DekontOdemeTarihi)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DosyaNo)
                .HasMaxLength(250)
                .HasColumnName("dosya_no");
            entity.Property(e => e.Durum)
                .HasMaxLength(250)
                .HasColumnName("durum");
            entity.Property(e => e.DuzenlemeTarihi)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ExchangeRate).HasMaxLength(250);
            entity.Property(e => e.FaturaGonderimTarihi)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FaturaHesabı)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.FaturaNo).HasMaxLength(50);
            entity.Property(e => e.FaturaTutari).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HareketId).HasColumnName("hareket_id");
            entity.Property(e => e.HareketTipi)
                .HasMaxLength(250)
                .HasColumnName("hareket_tipi");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IlgiliDosya)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilgili_dosya");
            entity.Property(e => e.InvoiceStatus).HasColumnName("invoiceStatus");
            entity.Property(e => e.IsMainBatch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("isMainBatch");
            entity.Property(e => e.Iskonto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("iskonto");
            entity.Property(e => e.Kdv).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Komisyon)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("komisyon");
            entity.Property(e => e.MusteriAciklama).HasMaxLength(500);
            entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OdemeId).HasColumnName("OdemeID");
            entity.Property(e => e.OrganizaitoSwiftCode).HasMaxLength(250);
            entity.Property(e => e.OrganizaitonAdres).HasMaxLength(350);
            entity.Property(e => e.OrganizaitonBanka).HasMaxLength(250);
            entity.Property(e => e.OrganizaitonBankaHesapNumarasi).HasMaxLength(250);
            entity.Property(e => e.OrganizaitonBankaHesapSahibi).HasMaxLength(250);
            entity.Property(e => e.OrganizaitonBankaSubeAdi).HasMaxLength(205);
            entity.Property(e => e.OrganizaitonBankaSubeKodu).HasMaxLength(250);
            entity.Property(e => e.OrganizaitonCurrency).HasMaxLength(250);
            entity.Property(e => e.OrganizaitonEmail).HasMaxLength(250);
            entity.Property(e => e.OrganizaitonIban).HasMaxLength(250);
            entity.Property(e => e.OrganizaitonName).HasMaxLength(100);
            entity.Property(e => e.OrganizaitonPostaKodu).HasMaxLength(50);
            entity.Property(e => e.OrganizaitonRoutingNumber).HasMaxLength(205);
            entity.Property(e => e.OrganizaitonSehir)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrganizaitonUlke)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrganizaitonUlkeEn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OrganizaitonUlkeEN");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
            entity.Property(e => e.SabitTelefon)
                .HasMaxLength(25)
                .HasColumnName("sabit_telefon");
            entity.Property(e => e.TahsilatParaBirimi).HasMaxLength(6);
            entity.Property(e => e.TahsilatTarihi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tahsilat_tarihi");
            entity.Property(e => e.TahsilatTutari).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Taraf).HasMaxLength(100);
            entity.Property(e => e.TarafBanka).HasMaxLength(250);
            entity.Property(e => e.TarafDosyaNo).HasMaxLength(250);
            entity.Property(e => e.VergiDairesi)
                .HasMaxLength(250)
                .HasColumnName("vergi_dairesi");
            entity.Property(e => e.VergiNumarasi)
                .HasMaxLength(50)
                .HasColumnName("vergi_numarasi");
        });

        modelBuilder.Entity<GetInvoiceListDraft>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetInvoiceListDraft");

            entity.Property(e => e.BacthInvoiceId)
                .HasMaxLength(250)
                .HasColumnName("BacthInvoiceID");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.DuzenlemeTarihi)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ExchangeRate).HasMaxLength(250);
            entity.Property(e => e.FaturaGonderimTarihi)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FaturaNo).HasMaxLength(50);
            entity.Property(e => e.FaturaTutari).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HareketId).HasColumnName("hareket_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IlgiliDosya)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilgili_dosya");
            entity.Property(e => e.InvoiceStatus).HasColumnName("invoiceStatus");
            entity.Property(e => e.IsMainBatch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("isMainBatch");
            entity.Property(e => e.KayitTarihi)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Komisyon)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("komisyon");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
            entity.Property(e => e.Taraf).HasMaxLength(100);
            entity.Property(e => e.TarafDosyaNo).HasMaxLength(250);
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tutar");
        });

        modelBuilder.Entity<GetOpenFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetOpenFiles");

            entity.Property(e => e.BorcTutari)
                .HasMaxLength(50)
                .HasColumnName("borc_tutari");
            entity.Property(e => e.CozumortagiAdi)
                .HasMaxLength(100)
                .HasColumnName("cozumortagi_adi");
            entity.Property(e => e.CozumortagidosyaNo)
                .HasMaxLength(250)
                .HasColumnName("cozumortagidosya_no");
            entity.Property(e => e.DosyaAdi)
                .HasMaxLength(250)
                .HasColumnName("dosya_adi");
            entity.Property(e => e.DosyaDurumu)
                .HasMaxLength(250)
                .HasColumnName("dosya_durumu");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.DosyaNo).HasColumnName("dosya_no");
            entity.Property(e => e.GuncellenmeTarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("guncellenme_tarih");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OlusturulmaTarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarih");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
        });

        modelBuilder.Entity<GetTaraf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetTaraf");

            entity.Property(e => e.Ailesirano).HasMaxLength(150);
            entity.Property(e => e.Babaadi).HasMaxLength(150);
            entity.Property(e => e.CozumOrtagiDosyaId).HasColumnName("Cozum_ortagi_dosya_id");
            entity.Property(e => e.CozumortagiAdi)
                .HasMaxLength(100)
                .HasColumnName("cozumortagi_adi");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DogumYeri)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuncellemePersonel).HasColumnName("guncelleme_personel");
            entity.Property(e => e.GuncellemeTarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("guncelleme_tarih");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ilce)
                .HasMaxLength(150)
                .HasColumnName("ilce");
            entity.Property(e => e.IlgiliPersonel).HasColumnName("ilgili_personel");
            entity.Property(e => e.Nufuskayityeri).HasMaxLength(150);
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
            entity.Property(e => e.PartnerGuid).HasMaxLength(100);
            entity.Property(e => e.Personel).HasMaxLength(101);
            entity.Property(e => e.Sehir).HasMaxLength(150);
            entity.Property(e => e.Sektor)
                .HasMaxLength(250)
                .HasColumnName("sektor");
            entity.Property(e => e.Serino).HasMaxLength(150);
            entity.Property(e => e.Sirano).HasMaxLength(150);
            entity.Property(e => e.Taraf)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TarafNormalize)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TarafYetkiliAdSoyad)
                .HasMaxLength(250)
                .HasColumnName("Taraf_Yetkili_AdSoyad");
            entity.Property(e => e.Taraftipi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("taraftipi");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TicariUnvan)
                .HasMaxLength(250)
                .HasColumnName("ticari_unvan");
            entity.Property(e => e.Uyruk).HasMaxLength(150);
            entity.Property(e => e.VergiDairesi)
                .HasMaxLength(250)
                .HasColumnName("vergi_dairesi");
            entity.Property(e => e.VergiNumarasi)
                .HasMaxLength(50)
                .HasColumnName("vergi_numarasi");
        });

        modelBuilder.Entity<HazirDokumanParametreleri>(entity =>
        {
            entity.ToTable("HazirDokumanParametreleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sifati)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HazirDokumanTipleri>(entity =>
        {
            entity.ToTable("HazirDokumanTipleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate).HasColumnType("date");
            entity.Property(e => e.DokumanAdi).HasMaxLength(250);
        });

        modelBuilder.Entity<HitMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HitMessa__3213E83FEFDED91F");

            entity.ToTable("HitMessage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameEn).HasColumnName("NameEN");
            entity.Property(e => e.NameTr).HasColumnName("NameTR");
        });

        modelBuilder.Entity<IcraDavaDurusmalar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("icraDavaDurusmalar");

            entity.Property(e => e.Dokumanadi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("dokumanadi");
            entity.Property(e => e.Icraid).HasColumnName("icraid");
            entity.Property(e => e.Icratakipeesasno)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("icratakipeesasno");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IslemNotu).HasColumnName("islemNotu");
            entity.Property(e => e.IslemTipi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("islemTipi");
        });

        modelBuilder.Entity<IcraTakipTurleri>(entity =>
        {
            entity.ToTable("icra_takip_turleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TakipTuru)
                .HasMaxLength(250)
                .HasColumnName("takip_turu");
        });

        modelBuilder.Entity<IcralarBelgeKategori>(entity =>
        {
            entity.ToTable("icralar_belge_kategori");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.Kategori)
                .HasMaxLength(250)
                .HasColumnName("kategori");
        });

        modelBuilder.Entity<IcralarBelgeler>(entity =>
        {
            entity.ToTable("icralar_belgeler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dokuman).HasColumnName("dokuman");
            entity.Property(e => e.DokumanAdi).HasColumnName("dokuman_adi");
            entity.Property(e => e.KategoriId).HasColumnName("kategori_id");
            entity.Property(e => e.Klasor).HasColumnName("klasor");
        });

        modelBuilder.Entity<Il>(entity =>
        {
            entity.ToTable("Il");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IlAdi)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ilce>(entity =>
        {
            entity.ToTable("Ilce");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IlceAdi)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvoiceStatus>(entity =>
        {
            entity.ToTable("InvoiceStatus");

            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<Kurlar>(entity =>
        {
            entity.ToTable("Kurlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BanknoteBuying)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BanknoteSelling)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CrossOrder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CrossRateOther)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ForexBuying)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ForexSelling)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarih).HasColumnType("date");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.Property(e => e.CozumortagiId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("cozumortagi_id");
            entity.Property(e => e.LanguageId).HasMaxLength(10);
            entity.Property(e => e.LanguageName).HasMaxLength(50);
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("list");

            entity.Property(e => e.Membersid)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.ToTable("log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IpAdresi)
                .HasMaxLength(50)
                .HasColumnName("ip_adresi");
            entity.Property(e => e.Islem).HasColumnName("islem");
            entity.Property(e => e.Logtype)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarih).HasColumnName("tarih");
            entity.Property(e => e.Uye)
                .HasMaxLength(50)
                .HasColumnName("uye");
        });

        modelBuilder.Entity<MahkemeIcra>(entity =>
        {
            entity.ToTable("mahkeme_icra");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MahkemeAdi).HasColumnName("mahkeme_adi");
            entity.Property(e => e.Tip).HasColumnName("tip");
        });

        modelBuilder.Entity<MahkemeTipleri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MahkemeT__3214EC076E8CD5BC");

            entity.ToTable("MahkemeTipleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<MailFormatlari>(entity =>
        {
            entity.ToTable("mail_formatlari");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Icerik).HasColumnName("icerik");
            entity.Property(e => e.Mail).HasColumnName("mail");
        });

        modelBuilder.Entity<MailLog>(entity =>
        {
            entity.ToTable("MailLog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerMailId).HasColumnName("CustomerMailID");
            entity.Property(e => e.Islem).HasColumnName("islem");
            entity.Property(e => e.Logtype).HasMaxLength(250);
            entity.Property(e => e.MailAddress).HasMaxLength(250);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<MainMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MainMenu__3213E83FFDC425A7");

            entity.ToTable("MainMenu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsVisible).HasColumnName("isVisible");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MhbHaraketTuru>(entity =>
        {
            entity.ToTable("MHB_HaraketTuru");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HaraketTuruAdi)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MuhasebeBatchFatura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Muhasebe__3213E83FD32E2DA7");

            entity.ToTable("MuhasebeBatchFatura");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dosyano).HasMaxLength(50);
            entity.Property(e => e.FaturaNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KayitTarihi).HasColumnType("datetime");
            entity.Property(e => e.Tutar).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MuhasebeDurumlar>(entity =>
        {
            entity.ToTable("muhasebe_durumlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Durum)
                .HasMaxLength(250)
                .HasColumnName("durum");
        });

        modelBuilder.Entity<MuhasebeGelirvegiderler>(entity =>
        {
            entity.ToTable("muhasebe_gelirvegiderler");

            entity.HasIndex(e => e.Tarih, "t_Tarih")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Id, "t_id")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.FaturaNo, e.Id, e.CozumortagiId, e.Tarih }, "tset").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.BacthInvoiceId)
                .HasMaxLength(250)
                .HasColumnName("BacthInvoiceID");
            entity.Property(e => e.BankaId).HasColumnName("banka_id");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BorcluId).HasColumnName("Borclu_id");
            entity.Property(e => e.CozumortagiId).HasColumnName("cozumortagi_id");
            entity.Property(e => e.DokumanDurumu)
                .HasMaxLength(50)
                .HasColumnName("dokuman_durumu");
            entity.Property(e => e.Durum)
                .HasMaxLength(250)
                .HasColumnName("durum");
            entity.Property(e => e.DuzenlemeTarihi).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasMaxLength(250);
            entity.Property(e => e.FaturaGonderimTarihi).HasColumnType("datetime");
            entity.Property(e => e.FaturaNo).HasMaxLength(50);
            entity.Property(e => e.FaturaTutari).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HaraketTuruAdi).HasMaxLength(250);
            entity.Property(e => e.HareketId).HasColumnName("hareket_id");
            entity.Property(e => e.HareketTipi)
                .HasMaxLength(250)
                .HasColumnName("hareket_tipi");
            entity.Property(e => e.IlgiliDosya).HasColumnName("ilgili_dosya");
            entity.Property(e => e.IlgiliSmm).HasColumnName("ilgili_smm");
            entity.Property(e => e.InvoiceOrganizaitonId).HasColumnName("InvoiceOrganizaitonID");
            entity.Property(e => e.InvoiceStatus).HasColumnName("invoiceStatus");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.IsMainBatch).HasColumnName("isMainBatch");
            entity.Property(e => e.Iskonto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("iskonto");
            entity.Property(e => e.KayitSahibi).HasColumnName("kayit_sahibi");
            entity.Property(e => e.Kdv).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Komisyon)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("komisyon");
            entity.Property(e => e.MusteriAciklama).HasMaxLength(500);
            entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OdemeId).HasColumnName("OdemeID");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
            entity.Property(e => e.Roller).HasMaxLength(250);
            entity.Property(e => e.TahsilatParaBirimi).HasMaxLength(6);
            entity.Property(e => e.TahsilatTutari).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Tarafbankaid).HasColumnName("tarafbankaid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tlkurtari).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tutar");
        });

        modelBuilder.Entity<MuhasebeHareketleri>(entity =>
        {
            entity.ToTable("muhasebe_hareketleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HareketAdi)
                .HasMaxLength(250)
                .HasColumnName("hareket_adi");
        });

        modelBuilder.Entity<MuhasebeList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MuhasebeList");

            entity.Property(e => e.Asilalacaktutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("asilalacaktutari");
            entity.Property(e => e.BankaTipi)
                .HasMaxLength(24)
                .IsUnicode(false);
            entity.Property(e => e.BorcTutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("borc_tutari");
            entity.Property(e => e.DosyaAdi).HasMaxLength(250);
            entity.Property(e => e.DosyaId).HasColumnName("DosyaID");
            entity.Property(e => e.DosyaNo).HasMaxLength(250);
            entity.Property(e => e.DosyaParaBirim).HasMaxLength(50);
            entity.Property(e => e.FaturaNo).HasMaxLength(50);
            entity.Property(e => e.Faturami)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GonderenKurum).HasMaxLength(100);
            entity.Property(e => e.OdemeId).HasColumnName("OdemeID");
            entity.Property(e => e.OdemeTipi).HasMaxLength(250);
            entity.Property(e => e.OlusturulmaTarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarih");
            entity.Property(e => e.TahsilatTarihi)
                .HasColumnType("datetime")
                .HasColumnName("tahsilat_tarihi");
            entity.Property(e => e.Tahsilatparabirimi)
                .HasMaxLength(50)
                .HasColumnName("tahsilatparabirimi");
            entity.Property(e => e.Tahsilattutari)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tahsilattutari");
            entity.Property(e => e.TarafDosyaNo).HasMaxLength(250);
            entity.Property(e => e.TarafId).HasColumnName("TarafID");
        });

        modelBuilder.Entity<MuhasebeMasrafAvan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Muhasebe__3213E83FB159D743");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dosyaid)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FaturaNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.HaraketTuru)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.KalanTutar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KayitTarihi).HasColumnType("datetime");
            entity.Property(e => e.ParaBirimi).HasMaxLength(10);
            entity.Property(e => e.Tutar).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MuhasebeMasrafAvansDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Muhasebe__3213E83F4E6A7644");

            entity.ToTable("MuhasebeMasrafAvansDetay");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Faturano)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MasrafTutar).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Muhasebefatura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("muhasebefatura");

            entity.Property(e => e.ExchangeRate).HasMaxLength(250);
            entity.Property(e => e.Faturaparabirimi).HasMaxLength(50);
            entity.Property(e => e.KayitTarihi).HasColumnType("smalldatetime");
            entity.Property(e => e.Kur2).HasMaxLength(20);
            entity.Property(e => e.Kurdegeri).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OdemeId).HasColumnName("OdemeID");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
        });

        modelBuilder.Entity<OdemeList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OdemeList");

            entity.Property(e => e.Bid).HasColumnName("bid");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OdemeId).HasColumnName("odeme_id");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
        });

        modelBuilder.Entity<OdemelerBelgeKategori>(entity =>
        {
            entity.ToTable("odemeler_belge_kategori");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.Kategori)
                .HasMaxLength(250)
                .HasColumnName("kategori");
        });

        modelBuilder.Entity<OdemelerBelgeler>(entity =>
        {
            entity.ToTable("odemeler_belgeler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dokuman).HasColumnName("dokuman");
            entity.Property(e => e.DokumanAdi).HasColumnName("dokuman_adi");
            entity.Property(e => e.KategoriId).HasColumnName("kategori_id");
            entity.Property(e => e.Klasor).HasColumnName("klasor");
        });

        modelBuilder.Entity<OtomatikAktiviteFonksiyonlari>(entity =>
        {
            entity.ToTable("otomatik_aktivite_fonksiyonlari");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FonksiyonAdi)
                .HasMaxLength(250)
                .HasColumnName("fonksiyon_adi");
        });

        modelBuilder.Entity<OtomatikAktiviteler>(entity =>
        {
            entity.ToTable("otomatik_aktiviteler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AktiviteAdi)
                .HasMaxLength(250)
                .HasColumnName("aktivite_adi");
            entity.Property(e => e.AktiviteIhtimali).HasColumnName("aktivite_ihtimali");
            entity.Property(e => e.AktiviteNotu).HasColumnName("aktivite_notu");
            entity.Property(e => e.DosyaTipi).HasMaxLength(50);
            entity.Property(e => e.Durum).HasColumnName("durum");
            entity.Property(e => e.Gorevliler)
                .HasMaxLength(50)
                .HasColumnName("gorevliler");
            entity.Property(e => e.HangiIslemler)
                .HasMaxLength(50)
                .HasColumnName("hangi_islemler");
        });

        modelBuilder.Entity<ParaBirimi>(entity =>
        {
            entity.ToTable("para_birimi");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ParaBirimi1)
                .HasMaxLength(50)
                .HasColumnName("para_birimi");
        });

        modelBuilder.Entity<PartnerParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PartnerP__3213E83F1F7E2CC8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ParameterName).HasMaxLength(500);
            entity.Property(e => e.ParameterType).HasMaxLength(550);
            entity.Property(e => e.ParameterValue).HasMaxLength(500);
            entity.Property(e => e.ParamterValueTr)
                .HasMaxLength(500)
                .HasColumnName("ParamterValueTR");
        });

        modelBuilder.Entity<PartnerPermission>(entity =>
        {
            entity.ToTable("PartnerPermission");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdliTakip).HasMaxLength(150);
            entity.Property(e => e.Arama).HasMaxLength(150);
            entity.Property(e => e.Hukuk).HasMaxLength(150);
            entity.Property(e => e.IsGelistirme)
                .HasMaxLength(150)
                .HasColumnName("isGelistirme");
            entity.Property(e => e.IstihbaratDokumasyon)
                .HasMaxLength(150)
                .HasColumnName("istihbaratDokumasyon");
            entity.Property(e => e.Muhasebe).HasMaxLength(150);
            entity.Property(e => e.Raporlama).HasMaxLength(150);
            entity.Property(e => e.TarafId).HasColumnName("TarafID");
            entity.Property(e => e.YoneticiAvukat).HasMaxLength(150);
            entity.Property(e => e.Yonetim).HasMaxLength(150);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.CozumortagiId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("cozumortagi_id");
            entity.Property(e => e.RoleName).HasMaxLength(100);
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.Property(e => e.PermissionKey).HasMaxLength(100);

            entity.HasOne(d => d.Role).WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermissions_RoleId");
        });

        modelBuilder.Entity<Sayfa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sayfa");

            entity.Property(e => e.Borcluadi)
                .HasMaxLength(255)
                .HasColumnName("borcluadi");
            entity.Property(e => e.Borctutari).HasColumnName("borctutari");
            entity.Property(e => e.Dosyano)
                .HasMaxLength(255)
                .HasColumnName("dosyano");
            entity.Property(e => e.Parabirimi)
                .HasMaxLength(255)
                .HasColumnName("parabirimi");
            entity.Property(e => e.Tarafdosyano)
                .HasMaxLength(255)
                .HasColumnName("tarafdosyano");
        });

        modelBuilder.Entity<Sektorler>(entity =>
        {
            entity.ToTable("sektorler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SektorAdi)
                .HasMaxLength(250)
                .HasColumnName("sektor_adi");
        });

        modelBuilder.Entity<SubMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SubMenu");

            entity.ToTable("SubMenu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ControllerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IsSubMenu).HasColumnName("isSubMenu");
            entity.Property(e => e.Isvisible).HasColumnName("isvisible");
            entity.Property(e => e.MenuIcon)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RoleName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SubMenuName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TarafAdre>(entity =>
        {
            entity.ToTable("taraf_adres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Adres)
                .HasMaxLength(350)
                .HasColumnName("adres");
            entity.Property(e => e.AdresBasligi)
                .HasMaxLength(250)
                .HasColumnName("adres_basligi");
            entity.Property(e => e.EklenmeTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("eklenme_tarihi");
            entity.Property(e => e.Ilce)
                .HasMaxLength(100)
                .HasColumnName("ilce");
            entity.Property(e => e.PostaKodu)
                .HasMaxLength(50)
                .HasColumnName("posta_kodu");
            entity.Property(e => e.Sehir)
                .HasMaxLength(100)
                .HasColumnName("sehir");
            entity.Property(e => e.TarafId).HasColumnName("taraf_id");
            entity.Property(e => e.Ulke)
                .HasMaxLength(100)
                .HasColumnName("ulke");
        });

        modelBuilder.Entity<TarafBanka>(entity =>
        {
            entity.ToTable("taraf_banka");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.BankaAdi)
                .HasMaxLength(250)
                .HasColumnName("banka_adi");
            entity.Property(e => e.EklenmeTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("eklenme_tarihi");
            entity.Property(e => e.HesapNumarasi)
                .HasMaxLength(250)
                .HasColumnName("hesap_numarasi");
            entity.Property(e => e.HesapSahibi)
                .HasMaxLength(250)
                .HasColumnName("hesap_sahibi");
            entity.Property(e => e.IbanNumarasi)
                .HasMaxLength(250)
                .HasColumnName("iban_numarasi");
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(250)
                .HasColumnName("sube_kodu");
            entity.Property(e => e.SwiftKodu)
                .HasMaxLength(250)
                .HasColumnName("swift_kodu");
            entity.Property(e => e.TarafId).HasColumnName("taraf_id");
        });

        modelBuilder.Entity<TarafIletisim>(entity =>
        {
            entity.ToTable("taraf_iletisim");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.EklenmeTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("eklenme_tarihi");
            entity.Property(e => e.EmailAdresi)
                .HasMaxLength(250)
                .HasColumnName("email_adresi");
            entity.Property(e => e.FaksNumarasi)
                .HasMaxLength(25)
                .HasColumnName("faks_numarasi");
            entity.Property(e => e.GsmNumarasi)
                .HasMaxLength(25)
                .HasColumnName("gsm_numarasi");
            entity.Property(e => e.SabitTelefon)
                .HasMaxLength(25)
                .HasColumnName("sabit_telefon");
            entity.Property(e => e.TarafId).HasColumnName("taraf_id");
            entity.Property(e => e.WebSitesi)
                .HasMaxLength(250)
                .HasColumnName("web_sitesi");
        });

        modelBuilder.Entity<TarafReleation>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaNo).HasColumnName("dosya_no");
            entity.Property(e => e.TarafAdi).HasMaxLength(250);
            entity.Property(e => e.TarafSifati)
                .HasMaxLength(250)
                .HasColumnName("taraf_sifati");
        });

        modelBuilder.Entity<TarafSifatlari>(entity =>
        {
            entity.ToTable("taraf_sifatlari");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TarafSifatEn)
                .HasMaxLength(150)
                .HasColumnName("TarafSifatEN");
            entity.Property(e => e.TarafSifati)
                .HasMaxLength(150)
                .HasColumnName("taraf_sifati");
        });

        modelBuilder.Entity<Taraflar>(entity =>
        {
            entity.ToTable("taraflar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnaAdi)
                .HasMaxLength(250)
                .HasColumnName("ana_adi");
            entity.Property(e => e.BabaAdi)
                .HasMaxLength(250)
                .HasColumnName("baba_adi");
            entity.Property(e => e.Cinsiyet)
                .HasMaxLength(250)
                .HasColumnName("cinsiyet");
            entity.Property(e => e.DogumTarihi)
                .HasMaxLength(250)
                .HasColumnName("dogum_tarihi");
            entity.Property(e => e.DogumYeri)
                .HasMaxLength(250)
                .HasColumnName("dogum_yeri");
            entity.Property(e => e.GuncellemePersonel).HasColumnName("guncelleme_personel");
            entity.Property(e => e.GuncellemeTarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("guncelleme_tarih");
            entity.Property(e => e.Il)
                .HasMaxLength(250)
                .HasColumnName("il");
            entity.Property(e => e.Ilce)
                .HasMaxLength(250)
                .HasColumnName("ilce");
            entity.Property(e => e.KimlikNo)
                .HasMaxLength(250)
                .HasColumnName("kimlik_no");
            entity.Property(e => e.MedeniHali)
                .HasMaxLength(250)
                .HasColumnName("medeni_hali");
            entity.Property(e => e.No)
                .HasMaxLength(250)
                .HasColumnName("no");
            entity.Property(e => e.OlusturanPersonel).HasColumnName("olusturan_personel");
            entity.Property(e => e.OlusturulmaTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("olusturulma_tarihi");
            entity.Property(e => e.OncekiSoyadi)
                .HasMaxLength(250)
                .HasColumnName("onceki_soyadi");
            entity.Property(e => e.Sektor)
                .HasMaxLength(250)
                .HasColumnName("sektor");
            entity.Property(e => e.SeriNo)
                .HasMaxLength(250)
                .HasColumnName("seri_no");
            entity.Property(e => e.TarafAdi)
                .HasMaxLength(100)
                .HasColumnName("taraf_adi");
            entity.Property(e => e.TarafNo).HasColumnName("taraf_no");
            entity.Property(e => e.TicariUnvan)
                .HasMaxLength(250)
                .HasColumnName("ticari_unvan");
            entity.Property(e => e.VergiDairesi)
                .HasMaxLength(250)
                .HasColumnName("vergi_dairesi");
            entity.Property(e => e.VergiNumarasi)
                .HasMaxLength(50)
                .HasColumnName("vergi_numarasi");
        });

        modelBuilder.Entity<Taraflist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("taraflist");

            entity.Property(e => e.TarafId).HasColumnName("taraf_id");
        });

        modelBuilder.Entity<TeminatDokumanlar>(entity =>
        {
            entity.ToTable("teminat_dokumanlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dokuman).HasColumnName("dokuman");
            entity.Property(e => e.DokumanAdi).HasColumnName("dokuman_adi");
            entity.Property(e => e.KategoriId).HasColumnName("kategori_id");
            entity.Property(e => e.Klasor).HasColumnName("klasor");
        });

        modelBuilder.Entity<TeminatKategoriler>(entity =>
        {
            entity.ToTable("teminat_kategoriler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.Kategori).HasColumnName("kategori");
            entity.Property(e => e.TeminatId).HasColumnName("teminat_id");
        });

        modelBuilder.Entity<TwoFactorLogin>(entity =>
        {
            entity.ToTable("TwoFactorLogin");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isActive");
        });

        modelBuilder.Entity<Ulke>(entity =>
        {
            entity.ToTable("Ulke");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EnUs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("en_US");
            entity.Property(e => e.TrTr)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tr_TR");
            entity.Property(e => e.UlkeAdi)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UlkeKodlari>(entity =>
        {
            entity.HasKey(e => e.Ulkeadi).HasName("PK__UlkeKodl__F51061400DD36B57");

            entity.ToTable("UlkeKodlari");

            entity.Property(e => e.Ulkeadi)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("ulkeadi");
            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.DialCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("dial_code");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Code2Fa)
                .HasMaxLength(4)
                .HasColumnName("Code2FA");
            entity.Property(e => e.CozumortagiId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("cozumortagi_id");
            entity.Property(e => e.DisplayName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastDirectoryUpdate).HasColumnType("datetime");
            entity.Property(e => e.PasswordHash).HasMaxLength(86);
            entity.Property(e => e.PasswordSalt).HasMaxLength(10);
            entity.Property(e => e.Source).HasMaxLength(4);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserImage).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<UserPermission>(entity =>
        {
            entity.Property(e => e.Granted)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.PermissionKey).HasMaxLength(100);

            entity.HasOne(d => d.User).WithMany(p => p.UserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserPermissions_UserId");
        });

        modelBuilder.Entity<UserPreference>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PreferenceType).HasMaxLength(100);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_RoleId");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_UserId");
        });

        modelBuilder.Entity<UyeDurum>(entity =>
        {
            entity.ToTable("uye_durum");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Durum)
                .HasMaxLength(50)
                .HasColumnName("durum");
        });

        modelBuilder.Entity<UyeTarih>(entity =>
        {
            entity.ToTable("uye_tarih");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("tarih");
            entity.Property(e => e.UyeId).HasColumnName("uye_id");
        });

        modelBuilder.Entity<Uyeler>(entity =>
        {
            entity.ToTable("uyeler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .HasColumnName("adi");
            entity.Property(e => e.Departmanlar)
                .HasMaxLength(50)
                .HasColumnName("departmanlar");
            entity.Property(e => e.Durum).HasColumnName("durum");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Gsm)
                .HasMaxLength(50)
                .HasColumnName("gsm");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .HasColumnName("kullanici_adi");
            entity.Property(e => e.ProfilResmi)
                .HasMaxLength(250)
                .HasColumnName("profil_resmi");
            entity.Property(e => e.Roller).HasMaxLength(50);
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .HasColumnName("sifre");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(50)
                .HasColumnName("soyadi");
            entity.Property(e => e.TelDahili)
                .HasMaxLength(50)
                .HasColumnName("tel_dahili");
        });

        modelBuilder.Entity<UyelerTur>(entity =>
        {
            entity.ToTable("uyeler_tur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tur).HasColumnName("tur");
            entity.Property(e => e.TurTarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("tur_tarihi");
            entity.Property(e => e.UyeId).HasColumnName("uye_id");
        });

        modelBuilder.Entity<VergiDaireleri>(entity =>
        {
            entity.ToTable("vergi_daireleri");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<VersionInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VersionInfo");

            entity.Property(e => e.AppliedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1024);
        });

        modelBuilder.Entity<ViewGetBorcluBilgiler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_GetBorcluBilgiler");

            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Adres)
                .HasMaxLength(350)
                .HasColumnName("adres");
            entity.Property(e => e.Ailesirano).HasMaxLength(150);
            entity.Property(e => e.Babaadi).HasMaxLength(150);
            entity.Property(e => e.CozumortagiAdi)
                .HasMaxLength(100)
                .HasColumnName("cozumortagi_adi");
            entity.Property(e => e.DogumTarihi)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DogumYeri)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DosyaAdi)
                .HasMaxLength(250)
                .HasColumnName("dosya_adi");
            entity.Property(e => e.Dosyaid).HasColumnName("dosyaid");
            entity.Property(e => e.EmailAdresi)
                .HasMaxLength(250)
                .HasColumnName("email_adresi");
            entity.Property(e => e.GsmNumarasi)
                .HasMaxLength(25)
                .HasColumnName("gsm_numarasi");
            entity.Property(e => e.IlAdi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Ilce)
                .HasMaxLength(150)
                .HasColumnName("ilce");
            entity.Property(e => e.IlceAdi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nufuskayityeri).HasMaxLength(150);
            entity.Property(e => e.SabitTelefon)
                .HasMaxLength(25)
                .HasColumnName("sabit_telefon");
            entity.Property(e => e.Sehir).HasMaxLength(150);
            entity.Property(e => e.Sektor)
                .HasMaxLength(250)
                .HasColumnName("sektor");
            entity.Property(e => e.Serino).HasMaxLength(150);
            entity.Property(e => e.Sirano).HasMaxLength(150);
            entity.Property(e => e.TarafSifati)
                .HasMaxLength(250)
                .HasColumnName("taraf_sifati");
            entity.Property(e => e.Taraftipi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("taraftipi");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TicariUnvan)
                .HasMaxLength(250)
                .HasColumnName("ticari_unvan");
            entity.Property(e => e.Uyruk).HasMaxLength(150);
            entity.Property(e => e.VergiDairesi)
                .HasMaxLength(250)
                .HasColumnName("vergi_dairesi");
            entity.Property(e => e.VergiNumarasi)
                .HasMaxLength(50)
                .HasColumnName("vergi_numarasi");
        });

        modelBuilder.Entity<VwIletisim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_iletisim");

            entity.Property(e => e.CozumortagiId).HasColumnName("cozumortagi_id");
            entity.Property(e => e.DosyaId).HasColumnName("dosya_id");
            entity.Property(e => e.GsmNumarasi)
                .HasMaxLength(25)
                .HasColumnName("gsm_numarasi");
            entity.Property(e => e.SabitTelefon)
                .HasMaxLength(25)
                .HasColumnName("sabit_telefon");
            entity.Property(e => e.SifatId).HasColumnName("SifatID");
        });

        modelBuilder.Entity<Yetkiler>(entity =>
        {
            entity.ToTable("yetkiler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.YetkiAdi)
                .HasMaxLength(50)
                .HasColumnName("yetki_adi");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
