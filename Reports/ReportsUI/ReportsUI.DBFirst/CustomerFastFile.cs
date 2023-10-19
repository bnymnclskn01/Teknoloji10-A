using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CustomerFastFile
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string? FileName { get; set; }

    public string? FileNumber { get; set; }

    public string? CustomerFileNumber { get; set; }

    public int? FileStatus { get; set; }

    public DateTime? CreateDate { get; set; }

    public int DebtorId { get; set; }

    public DateTime? ApprovalptDate { get; set; }

    public decimal? Interest { get; set; }

    public decimal? DebtAmount { get; set; }

    public decimal? ReceivableAmount { get; set; }

    public decimal? Commission { get; set; }

    public int? CurrencyId { get; set; }

    public int? FileTypesId { get; set; }

    public int? CreateUserId { get; set; }

    public string? Notlar { get; set; }

    public string? CustomerDocuments { get; set; }

    public virtual ParaBirimi? Currency { get; set; }

    public virtual CozumOrtaklari? Customer { get; set; }

    public virtual FileStatus? FileStatusNavigation { get; set; }

    public virtual FileType? FileTypes { get; set; }
}
