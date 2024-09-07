using Robust.Shared.GameStates;

namespace Content.Server.Traits.Assorted.Components;

/// <summary>
///     This is used for any trait that modifies how an entity is affected by flashes.
/// </summary>
[RegisterComponent]
public sealed partial class FlashPropertyModifierComponent : Component
{
    /// <summary>
    ///     What to multiply the flash duration by
    /// </summary>
    [DataField("durationMultiplier")]
    public float DurationMultiplier { get; set; } = 1f;

    /// <summary>
    ///     How much eye damage can they take from flashes?
    /// </summary>
    [DataField("eyeDamage")]
    public int EyeDamage { get; set; } = 0;

    /// <summary>
    ///     Whats the chance of them taking eye damage from flashes?
    /// </summary>
    [DataField("eyeDamageChance")]
    public float EyeDamageChance { get; set; } = 0f;

}
