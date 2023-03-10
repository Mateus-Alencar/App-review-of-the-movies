using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aula03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btmImg(object sender, EventArgs e)
        {
            DisplayAlert("Atenção: ", "você clicou no botão!", "OK");
        }
    }
}
