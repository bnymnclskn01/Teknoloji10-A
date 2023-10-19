using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class AuditLog
{
    public long Id { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Action { get; set; } = null!;

    public DateTime ChangedOn { get; set; }

    public string TableName { get; set; } = null!;

    public int RowId { get; set; }

    public string? Module { get; set; }

    public string? Page { get; set; }

    public string? Changes { get; set; }
}
