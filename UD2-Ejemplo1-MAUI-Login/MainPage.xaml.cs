namespace UD2_Ejemplo1_MAUI_Login
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            #pragma warning disable CA1416 // API específica de plataforma
            await DisplayAlertAsync("Sistema", "Entrando en el sistema", "Aceptar");
            #pragma warning restore CA1416
        }
    }

}
