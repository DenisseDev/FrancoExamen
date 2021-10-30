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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario,string estudiante, string total)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado " + usuario;
            lblestudiante.Text = estudiante;
            decimal tot = decimal.Round(Convert.ToDecimal(total),2);
            txtTotal.Text = Convert.ToString(tot);
        }
    }
}