using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrancoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuarioF = "";
        string total = "";
        string estudiante = "";
        public Registro(string usuario)
        {
            InitializeComponent();
            usuarioF = usuario;
            lblUsuario.Text = "Usuario Conectado " + usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double montoTotal = 1800;
            double interes = (montoTotal * 0.05);
            double inicial = Convert.ToDouble(txtMontoInicial.Text);
            decimal mensual = Convert.ToDecimal(((montoTotal - inicial) / 3) + interes);
            txtMensual.Text = Convert.ToString(decimal.Round(mensual,2));
            total = Convert.ToString(((mensual * 3) + Convert.ToDecimal(inicial)));
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (txtMensual.Text != "" && txtMontoInicial.Text != "" && lblestudiante.Text != "")
            {
                await DisplayAlert("Mensaje informativo", "Elemento guardado con exito", "OK");
                await Navigation.PushAsync(new Resumen(usuarioF, lblestudiante.Text, total ));
            }
            else
            {
                await DisplayAlert("Mensaje informativo", "Ingrese todos los datos", "OK");
            }
        }
    }
}