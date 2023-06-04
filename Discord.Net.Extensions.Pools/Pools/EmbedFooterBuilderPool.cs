using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class EmbedFooterBuilderPool : Pool<EmbedFooterBuilder>
{
    public static EmbedFooterBuilderPool Pool { get; } = new EmbedFooterBuilderPool();

    public override void Return(EmbedFooterBuilder embedFooterBuilder)
    {
        embedFooterBuilder.Text = null;
        embedFooterBuilder.IconUrl = null;

        base.Return(embedFooterBuilder);
    }
}