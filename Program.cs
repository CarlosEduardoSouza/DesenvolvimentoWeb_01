using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Fiap01
{
    class Program
    {
        static void Main(string[] args)
        {
            //var intervalo = new Intervalo();
            //Console.WriteLine("Hello World!");

            BuildWebHost(args).Run();
           
        }
        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
    }
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        
        //app.Run(async (context)=> {
        //    await context.Response.WriteAsync("Espero que funcione!");
        //});


        //////
        app.UseMvc(routes=> {
            routes.MapRoute(
                  name:"autor",
                  template:"autor/{nome}",
                  defaults: new { controller = "Autor", action = "Index" });

            routes.MapRoute(
                 name: "autoresDoAno",
                 template: "{ano:int}/autor",
                 defaults: new { controller = "Autor", action = "ListaDosAutoresDoAno" });

            routes.MapRoute(
                name: "topicosDaCategoria",
                template: "{categoria}/{topico}",
                defaults: new { controller = "Topico", action = "Index" });
        });
    }
}
