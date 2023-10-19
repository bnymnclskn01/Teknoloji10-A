using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CustomerFilePermission
{
    public int Id { get; set; }

    public int? CustomerFileId { get; set; }

    public int GroupId { get; set; }

    public int? MemberId { get; set; }
}
