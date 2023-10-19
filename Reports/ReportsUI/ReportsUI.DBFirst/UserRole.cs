using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class UserRole
{
    public long UserRoleId { get; set; }

    public int UserId { get; set; }

    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
