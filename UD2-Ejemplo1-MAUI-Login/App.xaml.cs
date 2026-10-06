using System.Runtime.Versioning;

namespace UD2_Ejemplo1_MAUI_Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // No establecer MainPage aquí
        }

        [SupportedOSPlatform("android21.0")]
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage());
        }
    }
}
