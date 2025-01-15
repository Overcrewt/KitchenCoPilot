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
    }
}