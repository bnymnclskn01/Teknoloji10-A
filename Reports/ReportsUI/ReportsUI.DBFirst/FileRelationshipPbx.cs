using System;
using System.Collections.Generic;

namespace ReportsUI.DBFirst;

public partial class FileRelationshipPbx
{
    public int Id { get; set; }

    public string? InternalNumber { get; set; }

    public string? CallId { get; set; }

    public int? UserId { get; set; }

    public int? FileId { get; set; }

    public string? CallNumber { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CagriDurumu { get; set; }

    public string? SoundPath { get; set; }

    public string? CallDate { get; set; }
}
