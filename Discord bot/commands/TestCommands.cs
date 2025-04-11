using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Interactivity;
using Discord_bot;
using Discord_bot.config;
using DSharpPlus.CommandsNext.Attributes;
using static System.Net.WebRequestMethods;

namespace Discord_bot.commands
{
    public class TestCommands : BaseCommandModule
    {
        [Command("Quote")]
        public async Task Quote1(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"COOLifeguads quote is, https://cdn.discordapp.com/attachments/1265050817199607920/1358701831248937043/IMG_20250406_174949.jpg?ex=67f61eb0&is=67f4cd30&hm=775e48face2702293564b6dddb5f9f065571e6504b31ae6625a50d0faf89a5ce&");
        }

        [Command("Kick")]
        public async Task Kick1(CommandContext ctx, string userMentioned)
        {
            await ctx.Channel.SendMessageAsync($"The user {userMentioned} has been kicked");
        }

        [Command("NuclearBomb")]
        public async Task NuclearBomb1(CommandContext ctx, string userMentioned)
        {
            await ctx.Channel.SendMessageAsync($"The user {userMentioned} is being tracked and a nuclear missile will shortly be on its way!");
            await Task.Delay(5000);
            await ctx.Channel.SendMessageAsync("Package sent!");
            await Task.Delay(10000);
            await ctx.Channel.SendMessageAsync("Package delivered! Target has recieved Amazon delivery.");
        }

        [Command("PackageSend")]
        public async Task PackageSend1(CommandContext ctx, string userMentioned)
        {
            await ctx.Channel.SendMessageAsync("https://tenor.com/view/explosion-gif-20062805");
        }
    }

}
