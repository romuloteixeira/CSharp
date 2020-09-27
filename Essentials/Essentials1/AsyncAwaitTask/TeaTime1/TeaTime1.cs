using Essentials1.Helpers.Extension;
using System.Net.Http;
using System.Threading.Tasks;

namespace Essentials1.AsyncAwaitTask.TeaTime1
{
    public static class TeaTime1
    {
        public static void Run()
        {
            MakeTeaAsync().Wait();
        }

        private static async Task<string> MakeTeaAsync()
        {
            var boilingWater = BoilWaterAsync();

            "Take the cups out.".WriteLine();

            var a = 0;
            for (var i = 0; i > 100_000_000; i++)
            {
                a += i;
            }

            "Put tea in cups.".WriteLine();

            var water = await boilingWater;
            var tea = $"Pour {water} in cups.";
            tea.WriteLine();

            return tea;
        }

        private static async Task<string> BoilWaterAsync()
        {
            "Start the kettle.".WriteLine();
            "Waiting for the kettle ...".WriteLine();
            await Task.Delay(400);

            "Kettle finished boiling.".WriteLine();

            return "water";
        }
    }
}
