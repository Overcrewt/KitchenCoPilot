using System;
using Microsoft.Maui.Controls;

namespace KitchenCoPilot
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void OnFeedbackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FeedbackPage());
        }
        private async void OnDeveloperInfoButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeveloperInfoPage());
        }
        private void OnDonateButtonClicked(object sender, EventArgs e)
        {
            var url = "https://www.donateme.co/";
            Launcher.OpenAsync(new Uri(url));
        }
    }
}