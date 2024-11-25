using BurgerAppDCCornejo.Models;
using Newtonsoft.Json;

namespace BurgerAppDCCornejo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri("https://localhost:7007/api/");
            var response = cliente.GetAsync("burger").Result;

            if (response.IsSuccessStatusCode)
            {
                var burgers = response.Content.ReadAsStringAsync().Result;
                var burgersList = JsonConvert.DeserializeObject<List<Burger>>(burgers);
                ListaView.ItemsSource = burgersList;
            }
        }
    }

}
