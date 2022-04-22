using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazeo.Logging
{
    internal interface IDiscordLogger
    {
        public Task DiscordLogEvent(LogMessage message);
    }
}
