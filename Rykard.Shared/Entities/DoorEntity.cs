using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rykard.Shared.Entities;

[Table("doors")]
public class DoorEntity
{
    [Key, Column("id")] public string Id { get; init; } = Guid.NewGuid().ToString();
    [Required, Column("created_at")] public DateTime CreatedAt { get; init; } = DateTime.Now;
    [Column("edited_at")] public DateTime EditedAt { get; init; } = default!;
    [Column("last_edit_by")] public UserEntity LastEditBy { get; init; } = default!;
    [Required, Column("visible")] public bool IsVisible { get; init; } = true;
    [Required, Column("available")] public bool IsAvailable { get; init; } = true;
    [Required, Column("created_by")] public UserEntity CreatedBy { get; init; } = default!;

    [Required, MinLength(3), MaxLength(64), Column("title")]
    public string Title { get; init; } = default!;

    [MinLength(3), MaxLength(512), Column("description")]
    public string Description { get; init; } = default!;
}