using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class FileType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsClient { get; set; }

    public virtual ICollection<CustomerFastFile> CustomerFastFiles { get; set; } = new List<CustomerFastFile>();
}
