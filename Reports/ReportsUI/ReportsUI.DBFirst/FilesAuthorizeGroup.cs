using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class FilesAuthorizeGroup
{
    public int Id { get; set; }

    public string? AuthorizeName { get; set; }

    public bool? IsActive { get; set; }
}
