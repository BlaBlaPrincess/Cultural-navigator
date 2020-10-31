using System.Diagnostics;
using Xamarin.Forms;

namespace Navigator.Pages.Loading
{
    public partial class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            InitializeComponent();
            Debug.WriteLine("Loading page has been loaded");
        }

        protected override async void OnAppearing()
        {
            await Shell.Current.GoToAsync("///main/tags");
        }
    }
}
