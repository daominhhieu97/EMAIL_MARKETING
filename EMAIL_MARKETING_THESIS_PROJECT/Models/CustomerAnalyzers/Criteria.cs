using System;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public  class Criteria
    {
        public Criteria(Func<Subscribers.Subscriber, bool> predicate)
        {
            this.Predicate = predicate;
        }

        public Func<Subscribers.Subscriber, bool> Predicate { get; set; }
    }
}