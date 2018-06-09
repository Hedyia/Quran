using Acr.UserDialogs;
using Newtonsoft.Json;
using Quran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quran
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class SurahPage : ContentPage
    {
        public Surah SurahData { get; set; }
        HttpClient _client;
        private const string _url = "http://api.alquran.cloud/quran";
        public SurahPage()
        {
            InitializeComponent();
            _client = new HttpClient();
            this.LoadQuran();
            lstSurah.ItemSelected += OnSelectedSurah;
        }

        private void LoadQuran()
        {
            UserDialogs.Instance.ShowLoading("Loading", MaskType.Black);

            LoadingAPI().ContinueWith((task) => { UserDialogs.Instance.HideLoading(); });

        }

        private async Task LoadingAPI()
        {
            var content = await _client.GetStringAsync(_url);
            var surahList = JsonConvert.DeserializeObject<Models.Quran>(content);

            lstSurah.ItemsSource = surahList.data.surahs;
        }
        private async void OnSelectedSurah(object sender, SelectedItemChangedEventArgs e)
        {
            var surah = e.SelectedItem as Surah;
            await Navigation.PushAsync(new SurahDetailPage(surah));
        }
    }
}