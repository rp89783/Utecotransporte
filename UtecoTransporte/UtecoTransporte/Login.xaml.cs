using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UtecoTransporte
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtNombreUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNombreUsuario.Text != "")
            {
                lblNombre.Text = "Nombre de usuario";
            }
            else
            {
                lblNombre.Text = "";
            }
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPass.Text != "")
            {
                lblPass.Text = "Contraseña";
            }
            else
            {
                lblPass.Text  = "";
            }
        }
    }
}