using System.Collections.ObjectModel;

namespace KitchenCoPilot
{
    public class FeedbackViewModel
    {
        public ObservableCollection<Feedback> Feedbacks { get; set; }

        public FeedbackViewModel()
        {
            Feedbacks = new ObservableCollection<Feedback>();
        }

        public void AddFeedback(Feedback feedback)
        {
            Feedbacks.Add(feedback);
        }
    }
}
