using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OceneFilmova.BazaPodataka;
using OceneFilmova.Domen.Funkcionalnosti;
using OceneFilmova.Domen.Interfejsi;
using OceneFilmova.UI.Modeli;

namespace OceneFilmova.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.\
            var host = CreateHostBuilder();
            ApplicationConfiguration.Initialize();
            Application.Run(host.Services.GetRequiredService<Filmovi>());
            await host.RunAsync();
        }

        private static IHost CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(servisi =>
                {
                    servisi.AddTransient<FilmServis>();
                    servisi.AddTransient<TagServis>();
                    servisi.AddTransient<GlumacServis>();
                    servisi.AddScoped<IFilmoviDbContext, FilmoviDbContext>();
                    servisi.AddScoped<NavigacioniServis>();
                    servisi.AddScoped<IServiceProvider, ServiceProvider>();
                    servisi.AddScoped<Filmovi>();
                    servisi.AddScoped<Glumci>();
                    servisi.AddScoped<Tagovi>();
                })
                .Build();
        }
    }
}