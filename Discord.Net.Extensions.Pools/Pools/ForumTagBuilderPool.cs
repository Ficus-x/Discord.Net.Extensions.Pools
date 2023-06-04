using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class ForumTagBuilderPool : Pool<ForumTagBuilder>
{
    public static ForumTagBuilderPool Pool { get; } = new ForumTagBuilderPool();

    public override void Return(ForumTagBuilder forumTagBuilder)
    {
        forumTagBuilder.Id = null;
        forumTagBuilder.IsModerated = false;
        forumTagBuilder.Emoji = null;

        base.Return(forumTagBuilder);
    }
}