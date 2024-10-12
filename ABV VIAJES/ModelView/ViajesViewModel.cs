using ABV_VIAJES.Model;
using ABV_VIAJES.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ABV_VIAJES.ModelView
{
    public class ViajesViewModel : BindableObject
    {
        private readonly SupabaseService _supabaseService;
        private ObservableCollection<Viaje> _viajes;

        public ObservableCollection<Viaje> Viajes
        {
            get => _viajes;
            set
            {
                _viajes = value;
                OnPropertyChanged();
            }
        }

        public ICommand CargarViajesCommand { get; }

        public ViajesViewModel()
        {
            _supabaseService = new SupabaseService();
            CargarViajesCommand = new Command(async () => await CargarViajes());
            Viajes = new ObservableCollection<Viaje>();

            // Llamar al método para cargar viajes al inicializar el ViewModel
            CargarViajes().ConfigureAwait(false);
        }

        private async Task CargarViajes()
        {
            var viajes = await _supabaseService.ObtenerViajes();
            Viajes.Clear();

            foreach (var viaje in viajes)
            {
                Viajes.Add(viaje);
            }
        }
    }
}
