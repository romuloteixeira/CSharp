using Essentials1.Helpers.Extension;
using System;
using System.Net.Http;

namespace Essentials1.AsyncAwaitTask.CallWebSite
{
    public static class CallWebSite
    {
        public static void Run()
        {
            MakeCallWebSite();
        }

        private static async void MakeCallWebSite()
        {
            var client = new HttpClient();
            $"Calling first site - Date: {DateTime.Now}:{DateTime.Now.Millisecond}".WriteLine();
            var task1 = await client.GetStringAsync("http://google.com");

            $"Loop time - Date: {DateTime.Now}:{DateTime.Now.Millisecond}".WriteLine();
            var a = 0;
            for (int i = 0; i < 1_000_000; i++)
            {
                a = i + 1;
            }
            
            $"Calling second site - Date: {DateTime.Now}:{DateTime.Now.Millisecond}".WriteLine();
            var task2 = await client.GetStringAsync("https://google.com");

            $"The end of work- Date: {DateTime.Now}:{DateTime.Now.Millisecond}".WriteLine();
        }
    }
}
