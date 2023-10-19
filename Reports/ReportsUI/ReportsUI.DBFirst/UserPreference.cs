using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class UserPreference
{
    public int UserPreferenceId { get; set; }

    public long UserId { get; set; }

    public string PreferenceType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
