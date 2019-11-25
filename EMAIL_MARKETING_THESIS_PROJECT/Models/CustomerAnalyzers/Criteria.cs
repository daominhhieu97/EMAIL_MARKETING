using System;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public abstract class Criteria <T>
    {
        public Criteria(Func<T,bool> predicate)
        {
            this.Predicate = predicate;
        }

        public Func<T, bool> Predicate { get; set; }
    }
}