using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace practica55
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ButtonSig_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new formulario()));
        }
        

    }
}
