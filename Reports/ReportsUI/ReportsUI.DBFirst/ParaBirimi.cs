using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class ParaBirimi
{
    public int Id { get; set; }

    public string? ParaBirimi1 { get; set; }

    public virtual ICollection<CustomerFastFile> CustomerFastFiles { get; set; } = new List<CustomerFastFile>();
}
