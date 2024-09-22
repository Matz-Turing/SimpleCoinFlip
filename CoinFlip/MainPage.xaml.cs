using System;
using Microsoft.Maui.Controls;

namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        private string caraImageSource = "cara.png";
        private string coroaImageSource = "coroa.png";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnJogarButtonClicked(object sender, EventArgs e)
        {
            if (UserChoicePicker.SelectedIndex == -1)
            {
                DisplayAlert("Erro", "Por favor, selecione Cara ou Coroa", "OK");
                return;
            }

            string userChoice = UserChoicePicker.SelectedItem.ToString();

            Random random = new Random();
            bool flipResult = random.Next(0, 2) == 0;
            string flipResultString = flipResult ? "Cara" : "Coroa";

            ResultImage.Source = flipResult ? caraImageSource : coroaImageSource;

            string resultadoTexto = $"Você pediu {userChoice} e deu {flipResultString}";

            if (userChoice == flipResultString)
            {
                DisplayAlert("Resultado", $"{resultadoTexto}\nVocê venceu!", "OK");
            }
            else
            {
                DisplayAlert("Resultado", $"{resultadoTexto}\nVocê perdeu!", "OK");
            }
        }
    }
}