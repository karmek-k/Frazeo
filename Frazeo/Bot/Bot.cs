using Discord;
using Discord.WebSocket;
using Frazeo.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazeo.Bot
{
    internal class FrazeoBot : IBot
    {
        private readonly DiscordSocketClient _client;
        private readonly IDatabase _db;

        public FrazeoBot(IDatabase db)
        {
            _client = new DiscordSocketClient();
            _db = db;
        }

        public async Task Start(string token)
        {
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
        }

        public async Task StartAndBlock(string token)
        {
            await Start(token);
            await Task.Delay(-1);
        }
    }
}
