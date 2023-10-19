using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class CaseMessage
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? PersonalId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IsRead { get; set; }

    public string? MessageFile { get; set; }

    public int? DosyaId { get; set; }

    public int? MessageStatus { get; set; }

    public int? CustomerUserId { get; set; }

    public string? MessageText { get; set; }

    public string? Username { get; set; }

    public string? FileUrl { get; set; }
}
