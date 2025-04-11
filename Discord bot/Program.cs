using Discord_bot.config;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using System.Threading.Tasks;
using Discord_bot.commands;
using DSharpPlus.SlashCommands.Attributes;
using DSharpPlus.SlashCommands.EventArgs;
using DSharpPlus.SlashCommands;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.CommandsNext.Entities;


namespace Discord_bot
{
    internal class Program
    {
        private static DiscordClient Client { get; set; }
        private static CommandsNextExtension Commands { get; set; }
        
        static async Task Main(string[] args)
        {
            var jsonReader = new JSONreader();
            await jsonReader.ReadJSON();

            var discordConfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = jsonReader.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true
               
            };

            Client = new DiscordClient(discordConfig);

            Client.Ready += Client_Ready;

            var commandsConfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new string[] { jsonReader.prefix },
                EnableMentionPrefix = true,
                EnableDms = true,
                EnableDefaultHelp = false

            };

            Commands = Client.UseCommandsNext(commandsConfig);
            var SlashCommandsConfig = Client.UseSlashCommands();
            


            Commands.RegisterCommands<TestCommands>();
            SlashCommandsConfig.RegisterCommands<SLCommands>();

            await Client.ConnectAsync();
            await Task.Delay(-1);
        }

        private static Task Client_Ready(DiscordClient sender, DSharpPlus.EventArgs.ReadyEventArgs args)
        {
            return Task.CompletedTask;
        }
    }
}
