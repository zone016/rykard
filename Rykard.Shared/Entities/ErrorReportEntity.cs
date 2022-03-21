using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rykard.Shared.Entities;

[Table("reports")]
public class ErrorReportEntity
{
    [Key, Column("id")] public string Id { get; init; } = Guid.NewGuid().ToString();
    [Required, Column("created_at")] public DateTime CreatedAt { get; init; } = DateTime.Now;
    [Required, Column("reported_by")] public UserEntity ReportedBy { get; init; } = default!;

    [MaxLength(512), Column("description")]
    public string Description { get; init; } = default!;
}