using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers
{
    public class RFMSubscriber : Subscriber
    {
        public float? Frequency { get; set; }

        public float? Recency { get; set; }

        public float? Monetary { get; set; }

        public string RFMClass { get; set; }
    }
}