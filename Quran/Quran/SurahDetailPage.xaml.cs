using Quran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quran
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurahDetailPage : ContentPage
	{
		public SurahDetailPage ( Surah _surah )
		{
			InitializeComponent ();
            BindingContext = _surah;

        }
	}
}