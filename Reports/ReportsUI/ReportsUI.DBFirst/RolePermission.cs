using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class RolePermission
{
    public long RolePermissionId { get; set; }

    public int RoleId { get; set; }

    public string PermissionKey { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
