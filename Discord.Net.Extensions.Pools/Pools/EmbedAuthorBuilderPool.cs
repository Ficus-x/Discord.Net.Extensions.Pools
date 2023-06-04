using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class EmbedAuthorBuilderPool : Pool<EmbedAuthorBuilder>
{
    public static EmbedAuthorBuilderPool Pool { get; } = new EmbedAuthorBuilderPool();

    public override void Return(EmbedAuthorBuilder embedAuthorBuilder)
    {
        embedAuthorBuilder.Name = null;
        embedAuthorBuilder.Url = null;
        embedAuthorBuilder.IconUrl = null;

        base.Return(embedAuthorBuilder);
    }
}