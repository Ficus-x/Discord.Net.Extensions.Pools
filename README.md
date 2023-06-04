# Discord.Net.Extensions.Pools
<p align="center">
  <a href="https://www.nuget.org/packages/Discord.Net.Extensions.Pools/">
    <img src="https://img.shields.io/nuget/v/Discord.Net.Extensions.Pools?style=flat" alt="NuGet">
  </a>
  <a href="https://discord.gg/dnet">
    <img src="https://discord.com/api/guilds/848176216011046962/widget.png" alt="Discord">
  </a>
</p>

An Discord.Net extension which provides pool system for a lot of builders.

## Installation
- [Nuget](https://www.nuget.org/packages/Discord.Net.Extensions.Pools)

## Examples
Let's take a `EmbedBuilder`. Now you don't need to make an new instance of `EmbedBuidler`. Use EmbedBuilderPool.

```cs
EmbedBuilder embedBuilder = EmbedBuilderPool.Pool.Get()
    .WithTitle(embed.EmbedTitle)
    .WithDescription(embed.Description)
    .WithColor(255, 210, 153)
    .WithFooter(embed.Footer ?? string.Empty)
    .WithThumbnailUrl(embed.Thumbnail);

IUserMessage message = await Context.Channel.SendMessageAsync(embed: embedBuilder.Build());
await RespondAsync($"Message was successfully sent!\n{message.GetJumpUrl()}", ephemeral: true);

EmbedBuilderPool.Pool.Return(embedBuilder);
```
