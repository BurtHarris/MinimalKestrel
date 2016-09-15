using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace MinimalKestrel
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .Configure(app =>
                {
                    app.Run(async (context) => await context.Response.WriteAsync("Hi!"));
                })
                .Build();

            host.Run();
        }
    }
}
