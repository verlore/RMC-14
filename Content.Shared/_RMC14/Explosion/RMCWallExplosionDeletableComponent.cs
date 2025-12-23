using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Explosion;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedRMCExplosionSystem))]
public sealed partial class RMCWallExplosionDeletableComponent : Component
{
    [DataField, AutoNetworkedField]
    public bool? Gibbable;

    [DataField, AutoNetworkedField]
    public int SplatModifier = 1;

    [DataField, AutoNetworkedField]
    public SoundSpecifier? GibSoundOverride = null;
}
