using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class PartnerParameter
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string? ParameterName { get; set; }

    public string? ParameterValue { get; set; }

    public string? ParamterValueTr { get; set; }

    public string? ParameterType { get; set; }

    public int? Nodeid { get; set; }
}
