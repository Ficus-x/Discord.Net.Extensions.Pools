using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class EmbedBuilderPool : Pool<EmbedBuilder>
{
    public static EmbedBuilderPool Pool { get; } = new EmbedBuilderPool();

    public override void Return(EmbedBuilder embedBuilder)
    {
        embedBuilder.Author = null;
        embedBuilder.Title = null;
        embedBuilder.Description = null;
        embedBuilder.Color = null;
        embedBuilder.Footer = null;
        embedBuilder.Timestamp = null;
        embedBuilder.Url = null;
        embedBuilder.ImageUrl = null;
        embedBuilder.ThumbnailUrl = null;
        embedBuilder.Fields.Clear();

        base.Return(embedBuilder);
    }
}