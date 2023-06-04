using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class EmbedFieldBuilderPool : Pool<EmbedFieldBuilder>
{
    public static EmbedFieldBuilderPool Pool { get; } = new EmbedFieldBuilderPool();

    public override void Return(EmbedFieldBuilder embedFieldBuilder)
    {
        embedFieldBuilder.IsInline = false;

        base.Return(embedFieldBuilder);
    }
}