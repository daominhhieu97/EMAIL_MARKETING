﻿using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public interface IFiltering<T>
    {
        public List<T> Filter(MailingList<T> list, Criteria criteria);
    }
}