﻿using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CustomerPartner
{
    public int Id { get; set; }

    public string? TaxNumber { get; set; }

    public string? IdentificationNo { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? ContactTitle { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateUserId { get; set; }

    public string? Guid { get; set; }

    public string? Normalize { get; set; }

    public DateTime? BirthDate { get; set; }
}
