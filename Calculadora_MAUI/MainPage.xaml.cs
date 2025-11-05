namespace Calculadora_MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private bool TryGetNumbers(out double numero1, out double numero2)
        {
            numero1 = 0;
            numero2 = 0;

            if (!double.TryParse(txtNumero1.Text, out numero1) ||
                !double.TryParse(txtNumero2.Text, out numero2))
            {
                DisplayAlert("Error", "Por favor ingrese números válidos en ambos campos.", "OK");
                return false;
            }

            return true;
        }

        private void OnSumarClicked(object? sender, EventArgs e)
        {
            if (TryGetNumbers(out double numero1, out double numero2))
                lblResultado.Text = $"Resultado: {numero1 + numero2}";
        }

        private void OnRestarClicked(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double numero1, out double numero2))
                lblResultado.Text = $"Resultado: {numero1 - numero2}";
        }

        private void OnMultiplicarClicked(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double numero1, out double numero2))
                lblResultado.Text = $"Resultado: {numero1 * numero2}";
        }

        private void OnDividirClicked(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double numero1, out double numero2))
            {
                if (numero2 == 0)
                    DisplayAlert("Error", "No se puede dividir entre cero.", "OK");
                else
                    lblResultado.Text = $"Resultado: {numero1 / numero2}";
            }
        }

        private void OnLimpiarClicked(object sender, EventArgs e)
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblResultado.Text = "Resultado: ";
        }
    }
}
