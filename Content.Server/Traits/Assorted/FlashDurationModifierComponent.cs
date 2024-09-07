using Robust.Shared.GameStates;

namespace Content.Server.Traits.Assorted.Components;

/// <summary>
///     This is used for any trait that modifies how long an entity is affected by flashes.
/// </summary>
[RegisterComponent]
public sealed partial class FlashDurationModifierComponent : Component
{
    /// <summary>
    ///     What to multiply the flash duration by
    /// </summary>
    [DataField("durationMultiplier")]
    public float DurationMultiplier { get; set; } = 1f;

}
