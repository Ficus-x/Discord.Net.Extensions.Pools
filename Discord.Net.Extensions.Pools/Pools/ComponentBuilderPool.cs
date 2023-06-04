using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class ComponentBuilderPool : Pool<ComponentBuilder>
{
    public static ComponentBuilderPool Pool { get; } = new ComponentBuilderPool();

    public override void Return(ComponentBuilder componentBuilder)
    {
        componentBuilder.ActionRows.Clear();

        base.Return(componentBuilder);
    }
}