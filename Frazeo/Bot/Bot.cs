using Discord;
using Discord.WebSocket;
using Frazeo.Database.Models;
using Frazeo.Database.Repositories;
using Frazeo.Logging;
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

        public FrazeoBot(IDiscordLogger logger)
        {
            _client = new DiscordSocketClient();

            _client.Log += logger.DiscordLogEvent;
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
