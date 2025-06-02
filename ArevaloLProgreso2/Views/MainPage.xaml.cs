namespace ArevaloLProgreso2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void OnChisteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChistesPage());
        }
    }

}

