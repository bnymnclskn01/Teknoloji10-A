using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string? Email { get; set; }

    public string Source { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string PasswordSalt { get; set; } = null!;

    public DateTime? LastDirectoryUpdate { get; set; }

    public string? UserImage { get; set; }

    public DateTime InsertDate { get; set; }

    public int InsertUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateUserId { get; set; }

    public short IsActive { get; set; }

    public int CozumortagiId { get; set; }

    public string? Code2Fa { get; set; }

    public virtual ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
