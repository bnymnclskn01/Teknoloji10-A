using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class MainMenu
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Icon { get; set; }

    public int? OrderNumber { get; set; }

    public bool? IsVisible { get; set; }
}
