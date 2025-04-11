using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.CommandsNext;
using DSharpPlus.SlashCommands;
using DSharpPlus.Interactivity;
using System.IO;
using Discord_bot.config;
using Discord_bot;
using DSharpPlus.Entities;

namespace Discord_bot.commands
{
    public class SLCommands : ApplicationCommandModule
    {


        [SlashCommand("Quote", "This is COOLifeguards famous quote!")]
        public async Task Quote(InteractionContext ctx)
        {
            await ctx.DeferAsync();

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("COOLifeguads quote is, https://cdn.discordapp.com/attachments/1265050817199607920/1358701831248937043/IMG_20250406_174949.jpg?ex=67f61eb0&is=67f4cd30&hm=775e48face2702293564b6dddb5f9f065571e6504b31ae6625a50d0faf89a5ce&"));

        }

        [SlashCommand("Info", "This is COOLifeguards information")]
        public async Task Info(InteractionContext ctx)
        {
            await ctx.DeferAsync();

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Coming soon!"));


        }




        [SlashCommand("NuclearBomb", "Nuclear bombs a user")]
        public async Task bombUserCommand(InteractionContext ctx, [Option("User", "User to bomb")] DiscordUser member)
        {
            await ctx.DeferAsync();
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"The user {member.Username}  is being tracked and a nuclear missile will shortly be on its way!"));
            await Task.Delay(5000);
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Package sent!"));
            await Task.Delay(10000);
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Package delivered! Target has recieved amazon delivery."));      
        }

        [SlashCommand("r", "N/A")]
        public async Task rickRoll(InteractionContext ctx)
        {
            await ctx.DeferAsync();
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("<https://youtu.be/Yb6dZ1IFlKc>"));
        }

        //Command list is here

        [SlashCommand("cmds", "Gives a command list.")]
        public async Task cmds(InteractionContext ctx)
        {
            await ctx.DeferAsync();
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("**Here is the list of commands: \n/NuclearBomb \n/r \n/Info \n/Quote \n/Entertain \n/Clarkson \n/GiveCoffee \n/GiveTea \n/Erika \n/giverole **"));
        }

        [SlashCommand("Entertain", "A fun video.")]
        public async Task vid(InteractionContext ctx)
        {
            await ctx.DeferAsync();
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Here, this will keep you laughing for hours, https://www.youtube.com/watch?v=PZt1vnxonJk or theres, https://www.youtube.com/watch?v=FGgtwEQ-BTk"));
        }

        [SlashCommand("GiveCoffee", "Gives you a coffee.")]
        public async Task Coffee(InteractionContext ctx)
        {
            await ctx.DeferAsync();
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("https://tenor.com/view/tea-gif-5113892710076061143"));
        }

        [SlashCommand("Clarkson", "Funny videos of Clarkson.")]
        public async Task Clarkson(InteractionContext ctx)
        {
            await ctx.DeferAsync();
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("https://cdn.discordapp.com/attachments/514658236599894048/1359864748606488716/Clarkson_and_May_Green_Screen_Templates___Top_Gear_compilation.mp4?ex=67f9083d&is=67f7b6bd&hm=b25eb2235678d2457bc8752214f895881b230927e4003591e87d7eb2bab99e4d&"));
        }

        [SlashCommand("GiveTea", "Gives a specific user tea.")]
        public async Task teaCommand(InteractionContext ctx, [Option("User", "User to bomb")] DiscordUser member)
        {
            await ctx.DeferAsync();
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"Here is your tea, Sir {member.Username}"));


        }

        [SlashCommand("Erika", "Nothing bad...")]
        public async Task Erika(InteractionContext ctx)
        {
            await ctx.DeferAsync();
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("https://youtu.be/BkeKak1T7nw"));
        }

        [SlashCommand("Embed", "Test Embed")]
        public async Task Embed(InteractionContext ctx)
        {
            var message = new DiscordEmbedBuilder
            {
                Title = "This is my first embed",
                Description = $"This command was executed by {ctx.User.Username}",
                Color = DiscordColor.Orange
            };

            await ctx.Channel.SendMessageAsync(embed: message);
        }

        [SlashCommand("giverole", "Gives a role to a member.")]
        public async Task GiveRole(InteractionContext ctx, [Option("member", "Member to give the role to")] DiscordUser user, [Option("role", "Role to give")] DiscordRole role)       
        {
            var member = await ctx.Guild.GetMemberAsync(user.Id);
            await member.GrantRoleAsync(role);
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent($"Gave {role.Mention} to {member.Mention}."));
        }


    }



}
    
  
