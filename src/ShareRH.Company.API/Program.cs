using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ShareRH.Company.API
{
    /// <summary>
    /// Program initialization class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The startup method of the program.
        /// </summary>
        /// <param name="args">The arguments received from the script command.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates a host and starts the APIs.
        /// </summary>
        /// <param name="args">The arguments received from the script command.</param>
        /// <returns>An instance of <see cref="IHostBuilder"/>.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
