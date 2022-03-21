using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Rykard.Shared.Enums;

namespace Rykard.Shared.Entities;

[Table("door_actions")]
public class DoorActionEntity
{
    [Key, Column("id")] public string Id { get; init; } = Guid.NewGuid().ToString();
    [Required, Column("created_at")] public DateTime CreatedAt { get; init; } = DateTime.Now;
    [Required, Column("current_state")] public DoorState CurrentState { get; init; } = DoorState.Unknown;
    [Required, Column("desired_state")] public DoorState DesiredState { get; init; } = DoorState.Unknown;
    [Required, Column("running")] public bool IsRunning { get; init; } = false;
    [Required, Column("requested_by")] public UserEntity RequestedBy { get; init; } = default!;
}