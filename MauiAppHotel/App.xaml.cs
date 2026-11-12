namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Views.CadastroEventoPage());
            //MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
            MainPage = new NavigationPage(new Views.MenuPrincipalPage());
            //MainPage = new NavigationPage(new MainPage());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}
