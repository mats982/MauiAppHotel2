
using MauiAppHotel2.Models;

namespace MauiAppHotel2
{
    public partial class App : Application
    {
        public List<Quarto> Lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 200.0,
                ValorDiariaCriancas = 150.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 180.0,
                ValorDiariaCriancas = 140.0
            },
            new Quarto()
            {
                Descricao = "Suíte Premium",
                ValorDiariaAdulto = 150.0,
                ValorDiariaCriancas = 120.0
            },
            new Quarto()
            {
                Descricao = "Suíte Inicial",
                ValorDiariaAdulto = 120.0,
                ValorDiariaCriancas = 100.0
            }

        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContrataçãodaHospedagem());

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
