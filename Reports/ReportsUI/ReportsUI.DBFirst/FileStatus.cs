using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class FileStatus
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<CustomerFastFile> CustomerFastFiles { get; set; } = new List<CustomerFastFile>();
}
