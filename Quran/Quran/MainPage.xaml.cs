using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quran
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnCheckConnectivity.Clicked += (s, e) =>
              {
                 CheckConnectivity();
              };

        }

        private async void CheckConnectivity()
        {
            var IsConnected = CrossConnectivity.Current.IsConnected;
            if (!IsConnected)
            {
                await DisplayAlert("Connection Error", "Please check your internet connection.", "Ok");
                return;
            }
            await Navigation.PushAsync(new SurahPage());
        }
    }
}
