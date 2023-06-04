using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class ActionRowBuilderPool : Pool<ActionRowBuilder>
{
    public static ActionRowBuilderPool Pool { get; } = new ActionRowBuilderPool();

    public override void Return(ActionRowBuilder actionRowBuilder)
    {
        actionRowBuilder.Components.Clear();

        base.Return(actionRowBuilder);
    }
}