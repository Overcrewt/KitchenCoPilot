﻿namespace KitchenCoPilot
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnFeedbackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FeedbackPage());
        }
    }
}
