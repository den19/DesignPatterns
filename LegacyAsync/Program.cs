using System;
using System.Threading.Tasks;

namespace LegacyAsync
{
    class Program
    {
        static async Task MainAsync(string[] args)
        {
            //Console.WriteLine("Begin");
            //var manager = new ApmManager();
            //manager.BeginApmStyleMining($"https://asynccoinfunction.azurewebsites.net/api/asynccoin/4");
            //Console.ReadLine();

            //Console.WriteLine("start");
            //var manager = new IntegrationManager();
            //await manager.ExecuteAsync();
            //Console.ReadLine();

            //Console.WriteLine("start");
            //var manager = new EapManager();
            //manager.EapStyleMiningAsync(4);
            //Console.ReadLine();

            Console.WriteLine("start");
            var manager = new IntegrationManager();
            await manager.ExecuteAsync();
            Console.ReadLine();
        }
    }
}
