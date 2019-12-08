﻿using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists
{
    public class MailingListDetailsViewModel
    {
        public MailingListDetailsViewModel()
        {
            this.MailingList = new MailingList();
            this.AddSegmentationViewModel = new AddSegmentationViewModel();
        }

        public MailingList MailingList { get; set; }

        public List<Subscriber> Subscribers { get; set; }

        public AddSegmentationViewModel AddSegmentationViewModel { get; set; }

        public AddContactsViewModel AddContactsViewModel { get; set; }
    }

    public class AddContactsViewModel
    {
        public string Subscribers { get; set; }

        public int MailingListId { get; set; }
    }
}