using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazeo.Bot
{
    internal interface IBot
    {
        Task Start(string token);

        Task StartAndBlock(string token);
    }
}
