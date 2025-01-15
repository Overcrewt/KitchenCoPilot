using System.Text.RegularExpressions;

namespace KitchenCoPilot
{
    public partial class FeedbackPage : ContentPage
    {
        private int _rating;

        public FeedbackPage()
        {
            InitializeComponent();
            BindingContext = new FeedbackViewModel();
        }

        private void OnStarClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            _rating = int.Parse(Regex.Match(button.StyleId, @"\d+").Value);

            
            
        }

        

        private async void OnSubmitFeedbackClicked(object sender, EventArgs e)
        {
            if (BindingContext is FeedbackViewModel viewModel)
            {
                var feedback = new Feedback
                {
                    Rating = _rating,
                    Comment = FeedbackEditor.Text
                };

                viewModel.AddFeedback(feedback);
                FeedbackEditor.Text = string.Empty;
                _rating = 0;
                
            }
        }
    }
}
