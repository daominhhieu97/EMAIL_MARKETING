﻿using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public class Cluster <T>
    {
        public string Title { get; set; }

        public List<T> Subscribers { get; set; }
    }
}