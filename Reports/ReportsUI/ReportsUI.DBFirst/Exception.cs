using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class Exception
{
    public long Id { get; set; }

    public Guid Guid { get; set; }

    public string ApplicationName { get; set; } = null!;

    public string MachineName { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string Type { get; set; } = null!;

    public bool? IsProtected { get; set; }

    public string? Host { get; set; }

    public string? Url { get; set; }

    public string? Httpmethod { get; set; }

    public string? Ipaddress { get; set; }

    public string? Source { get; set; }

    public string? Message { get; set; }

    public string? Detail { get; set; }

    public int? StatusCode { get; set; }

    public string? Sql { get; set; }

    public DateTime? DeletionDate { get; set; }

    public string? FullJson { get; set; }

    public int? ErrorHash { get; set; }

    public int DuplicateCount { get; set; }
}
