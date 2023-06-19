using Xamarin.Forms;

namespace Estilos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EstilosHeredados();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
