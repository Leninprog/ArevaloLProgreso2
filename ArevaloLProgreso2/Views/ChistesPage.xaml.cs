using System.Net.Http.Json;
using Newtonsoft.Json;

namespace ArevaloLProgreso2.Views;
public partial class ChistesPage : ContentPage
{
    public ChistesPage()
    {
        InitializeComponent();
        ObtenerChiste();
    }

    private async void ObtenerChiste()
    {
        try
        {
            var cliente = new HttpClient();
            var chiste = await cliente.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
            var chisteMostrar = JsonConvert.DeserializeObject<Chiste>(chiste);
            ChisteLabel.Text = $"{chisteMostrar.setup}\n\n{chisteMostrar.Punchline}";
        }
        catch (Exception ex)
        {
            ChisteLabel.Text = $"Error al obtener el chiste";
        }
    }

    private void OnOtroChisteClicked(object sender, EventArgs e)
    {
        ObtenerChiste();
    }

    public class Chiste
    {
        public string setup { get; set; }
        public string Punchline { get; set; }
    }
}