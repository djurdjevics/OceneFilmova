using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace OceneFilmova.UI.Modeli
{
    public class NavigacioniServis
    {
        private readonly IServiceProvider _serviceProvider;
        public NavigacioniServis(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Show<T>() where T : Form
        {
            Form form = _serviceProvider.GetRequiredService<T>();
            form.Show();
        }
    }
}
