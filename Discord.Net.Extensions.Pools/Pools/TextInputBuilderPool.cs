using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class TextInputBuilderPool : Pool<TextInputBuilder>
{
    public static TextInputBuilderPool Pool { get; } = new TextInputBuilderPool();

    public override void Return(TextInputBuilder textInputBuilder)
    {
        textInputBuilder.CustomId = null;
        textInputBuilder.Style = TextInputStyle.Short;
        textInputBuilder.Label = null;
        textInputBuilder.Placeholder = null;
        textInputBuilder.MinLength = 0;
        textInputBuilder.MaxLength = 0;
        textInputBuilder.Required = false;
        textInputBuilder.Value = null;

        base.Return(textInputBuilder);
    }
}