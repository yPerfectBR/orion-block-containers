using Orion.PluginContracts;

namespace OrionBlockContainers;

/// <summary>
/// Vanilla chest/barrel block containers (S7 Api-only shell).
/// Full BlockTraitBase chest/barrel open + NBT sync returns once IBlock lifecycle
/// hooks cover OnInteract/OnRead without Orion.Block.BlockTrait.
/// </summary>
public sealed class OrionBlockContainersPlugin : IOrionPlugin
{
    public string Id => "orion:block_containers";

    public Version Version { get; } = new(1, 0, 0);

    public void Load(IPluginLoadContext context) => _ = context;

    public void OnEnable(IPluginContext context) => _ = context;

    public void OnWorldInitialize(IWorldInitContext context) => _ = context;

    public void OnDisable(IPluginContext context) => _ = context;
}
