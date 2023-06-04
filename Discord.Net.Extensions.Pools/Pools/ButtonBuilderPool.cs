using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class ButtonBuilderPool : Pool<ButtonBuilder>
{
    public static ButtonBuilderPool Pool { get; } = new ButtonBuilderPool();

    public override void Return(ButtonBuilder buttonBuilder)
    {
        buttonBuilder.Label = null;
        buttonBuilder.CustomId = null;
        buttonBuilder.Emote = null;
        buttonBuilder.Url = null;
        buttonBuilder.IsDisabled = false;
        buttonBuilder.Style = ButtonStyle.Primary;

        base.Return(buttonBuilder);
    }
}