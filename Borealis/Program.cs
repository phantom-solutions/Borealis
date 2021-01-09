using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Borealis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //THIS CREATES THE WEBSITE FRONT-END
            CreateHostBuilder(args).Build().Run();

        }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
