using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers
{
    public class RFMSubscriber : Subscriber
    {
        public int? RClass { get; set; }

        public int? FClass { get; set; }

        public int? MClass { get; set; }

        public string? RFMClass { get; set; }
    }
}