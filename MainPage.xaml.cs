namespace CalculadoraFC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLatidos.Text, out int latidos) || latidos < 0)
            {
                DisplayAlert(
                    "Error",
                    "Ingresa un número válido de latidos.",
                    "Aceptar");

                return;
            }

            int frecuencia = latidos * 4;

            lblFrecuencia.Text =
                $"Frecuencia cardiaca: {frecuencia} BPM";

            if (frecuencia < 60)
            {
                lblResultado.Text = "Frecuencia cardiaca baja";
                lblResultado.TextColor = Colors.Orange;
            }
            else if (frecuencia > 100)
            {
                lblResultado.Text = "Frecuencia cardiaca alta";
                lblResultado.TextColor = Colors.Red;
            }
            else
            {
                lblResultado.Text = "Frecuencia cardiaca normal";
                lblResultado.TextColor = Colors.Green;
            }
        }
    }
}
