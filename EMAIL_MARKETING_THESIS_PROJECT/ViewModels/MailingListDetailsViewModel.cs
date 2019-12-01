using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;

namespace EMAIL_MARKETING_THESIS_PROJECT.ViewModels
{
    internal class MailingListDetailsViewModel
    {
        public MailingListDetailsViewModel()
        {
        }

        public MailingList MailingList { get; internal set; }
        public object Subscribers { get; internal set; }
    }
}