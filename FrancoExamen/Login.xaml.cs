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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;
            if (usuario == "estudiante2021" && contrasenia == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                await DisplayAlert("Error", "Datos incorrectos", "OK");
            }
        }
    }
}