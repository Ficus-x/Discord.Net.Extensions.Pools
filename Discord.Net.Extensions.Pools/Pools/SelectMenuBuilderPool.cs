using Discord.Net.Extensions.Pools.Features;

namespace Discord.Net.Extensions.Pools;

public class SelectMenuBuilderPool : Pool<SelectMenuBuilder>
{
    public static SelectMenuBuilderPool Pool { get; } = new SelectMenuBuilderPool();

    public override void Return(SelectMenuBuilder selectMenuBuilder)
    {
        selectMenuBuilder.CustomId = null;
        selectMenuBuilder.Type = ComponentType.SelectMenu;
        selectMenuBuilder.Placeholder = null;
        selectMenuBuilder.MinValues = 1;
        selectMenuBuilder.MaxValues = 1;
        selectMenuBuilder.IsDisabled = false;
        selectMenuBuilder.Options.Clear();

        base.Return(selectMenuBuilder);
    }
}