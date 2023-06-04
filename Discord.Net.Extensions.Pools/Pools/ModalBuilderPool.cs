using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class ModalBuilderPool : Pool<ModalBuilder>
{
    public static ModalBuilderPool Pool { get; } = new ModalBuilderPool();

    public override void Return(ModalBuilder modalBuilder)
    {
        modalBuilder.CustomId = null;
        modalBuilder.Title = null;
        modalBuilder.CustomId = null;
        modalBuilder.Components.ActionRows.Clear();

        base.Return(modalBuilder);
    }
}