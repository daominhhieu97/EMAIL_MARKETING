﻿using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public class GeographicFiltering : IFiltering
    {
        public List<RFMSubscriber> Filter(List<RFMSubscriber> list, Criteria[] criteria)
        {
            throw new NotImplementedException();
        }
    }
}