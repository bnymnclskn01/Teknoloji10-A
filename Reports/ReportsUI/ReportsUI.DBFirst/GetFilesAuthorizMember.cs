using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class GetFilesAuthorizMember
{
    public int Id { get; set; }

    public int? Dosyaid { get; set; }

    public string? MemberListesi { get; set; }

    public int? YetkiGrubuid { get; set; }

    public string? YetkiGrubu { get; set; }
}
