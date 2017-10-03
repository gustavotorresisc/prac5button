using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace practica55
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formulario : ContentPage
    {
        public formulario()
        {
            InitializeComponent();
        }
        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            var nombre = boxNombre.Text;
            var apellido = boxApellido.Text;
            var direccion = boxDireccion.Text;
            var telefono = boxTelefono.Text;

            var correra = boxCarrera.Text;
            var semestre = boxSemestre.Text;
            var matricula = boxMatricula.Text;

            var correo = boxCorreo.Text;
            var github = boxGithub.Text;

            if (!string.IsNullOrEmpty(nombre + apellido + direccion))
            {
                boxNombre.IsEnabled = false;
                boxApellido.IsEnabled = false;
                boxDireccion.IsEnabled = false;
                boxTelefono.IsEnabled = false;
                boxCarrera.IsEnabled = false;
                boxSemestre.IsEnabled = false;
                boxMatricula.IsEnabled = false;
                boxCorreo.IsEnabled = false;
                boxGithub.IsEnabled = false;


                DisplayAlert("Bienvenido al Teconologico de Estudios Superiores de Huixquilucan", "Nombre:" + nombre + "\n" + "Apellidos:" + apellido + "\n" + "Direccion:" + direccion + "\n" + "Telefono:" + telefono + "\n" + "Carrera:" + correra + "\n" + "Semestre:" + semestre + "\n" + "Matricula:" + matricula + "\n" + "Correo:" + correo + "\n" + "GitHub:" + github + "\n", "Registrar");
                //Navigation.PushAsync(new Page());
            }
        }
        private void BtnEdit_Clicked(object sender, EventArgs e)
        {
            boxNombre.IsEnabled = true;
            boxApellido.IsEnabled = true;
            boxDireccion.IsEnabled = true;
            boxTelefono.IsEnabled = true;
            boxCarrera.IsEnabled = true;
            boxSemestre.IsEnabled = true;
            boxMatricula.IsEnabled = true;
            boxCorreo.IsEnabled = true;
            boxGithub.IsEnabled = true;
        }
        private void RegForm_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new MainPage()));
        }

        private void calcu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new calculadora()));
            
        }
    }
}