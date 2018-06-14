using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace crossPlat
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
		}
        private async void SayHelloButtonOnClicked(Object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            await DisplayAlert("Saludos", $"Hello {name}!"+$" nombre {SayHelloButton.Text}", "Cancel");
        }
	}
}
