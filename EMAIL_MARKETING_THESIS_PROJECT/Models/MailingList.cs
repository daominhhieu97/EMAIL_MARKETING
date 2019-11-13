﻿using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models
{
    public class MailingList
    {
        public int ListId { get; set; }

        public string Title { get; set; }

        public List<Subscriber> Subscribers { get; set; }
    }
}
