using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class GetOpenFile
{
    public int DosyaId { get; set; }

    public int? DosyaNo { get; set; }

    public string? DosyaAdi { get; set; }

    public string? CozumortagiAdi { get; set; }

    public string? CozumortagidosyaNo { get; set; }

    public string? DosyaDurumu { get; set; }

    public string? BorcTutari { get; set; }

    public string? ParaBirimi { get; set; }

    public int Id { get; set; }

    public DateTime? OlusturulmaTarih { get; set; }

    public DateTime? GuncellenmeTarih { get; set; }
}
