using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class SubMenu
{
    public int Id { get; set; }

    public int MainId { get; set; }

    public string? SubMenuName { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public int RoleId { get; set; }

    public bool IsSubMenu { get; set; }

    public string? RoleName { get; set; }

    public string? MenuIcon { get; set; }

    public int? Isvisible { get; set; }
}
