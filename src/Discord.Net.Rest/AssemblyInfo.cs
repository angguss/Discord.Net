using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Discord.Net.Rpc")]
[assembly: InternalsVisibleTo("Discord.Net.WebSocket")]
[assembly: InternalsVisibleTo("Discord.Net.Webhook")]
[assembly: InternalsVisibleTo("Discord.Net.Commands")]
[assembly: InternalsVisibleTo("Discord.Net.Tests")]

[assembly: TypeForwardedTo(typeof(Discord.EmbedBuilder))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedBuilderExtensions))]
