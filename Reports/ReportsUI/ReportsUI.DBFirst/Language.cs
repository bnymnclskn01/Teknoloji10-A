using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Language
{
    public int Id { get; set; }

    public string LanguageId { get; set; } = null!;

    public string LanguageName { get; set; } = null!;

    public int CozumortagiId { get; set; }
}
