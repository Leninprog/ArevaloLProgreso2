using ArevaloLProgreso2.Views;

namespace ArevaloLProgreso2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnInfoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }

        private async void OnChisteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChistesPage());
        }
    }

}

