using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public class Cluster
    {
        public string Title { get; set; }

        public List<RFMSubscriber> Subscribers { get; set; }
    }
}
