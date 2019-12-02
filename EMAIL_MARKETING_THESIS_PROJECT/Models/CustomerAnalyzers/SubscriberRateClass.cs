namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public abstract class SubscriberRateClass
    {
        public  string Champion;

        public string NeedToTakeCare;

        public string NormalCustomer;
    }

    public class RFMSubscriberRateClass : SubscriberRateClass
    {
        private const string champion = "144";

        private const string needToTakeCare = "111";

        private const string normalCustomer = "222";

        public new static string Champion => champion;

        public new static string NeedToTakeCare => needToTakeCare;

        public new static string NormalCustomer => normalCustomer;
    }

    public class IncomeSubscriberRateClass : SubscriberRateClass
    {

    }
}