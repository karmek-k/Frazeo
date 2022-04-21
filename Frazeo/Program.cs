using Frazeo.Bot;

namespace Frazeo
{
    public class Program
    {
        public async Task AsyncMain()
        {
            var bot = new FrazeoBot();
            var token = Environment.GetEnvironmentVariable("FRAZEO_TOKEN");

            await bot.Start(token);

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

        public static Task Main(string[] args) => new Program().AsyncMain();
    }
}