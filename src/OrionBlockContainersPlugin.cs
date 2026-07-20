using Orion.Block.Traits;
using Orion.PluginContracts;

namespace OrionBlockContainers;

/// <summary>
/// Vanilla chest/barrel block containers. Depends on VanillaContainers + OrionInventory.
/// </summary>
public sealed class OrionBlockContainersPlugin : IOrionPlugin
{
    public string Id => "orion:block-containers";

    public Version Version { get; } = new(1, 0, 0);

    public void Load(IPluginLoadContext context)
    {
        _ = context;
        BlockTraitRegistry.RegisterFromAssembly(typeof(OrionBlockContainersPlugin).Assembly);
    }

    public void OnEnable(IPluginContext context) => _ = context;

    public void OnWorldInitialize(IWorldInitContext context) => _ = context;

    public void OnDisable(IPluginContext context) => _ = context;
}
