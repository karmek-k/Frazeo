using Frazeo.Bot;
using Frazeo.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Frazeo
{
    public class Program
    {
        public async Task AsyncMain()
        {
            var bot = BuildServiceProvider().GetService<IBot>()!;
            var token = Environment.GetEnvironmentVariable("FRAZEO_TOKEN");

            if (token is null)
            {
                throw new Exception("No bot token provided - use the FRAZEO_TOKEN env variable");
            }

            await bot.Start(token);

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

        private static IServiceProvider BuildServiceProvider()
        {
            return new ServiceCollection()
                .AddSingleton<IBot, FrazeoBot>()
                .BuildServiceProvider();
        }

        public static Task Main(string[] args) => new Program().AsyncMain();
    }
}