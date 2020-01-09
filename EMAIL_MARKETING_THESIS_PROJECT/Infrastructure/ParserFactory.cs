namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class ParserFactory
    {
        public static RFMSubscriberParser CreateRFMParser()
        {
            return new RFMSubscriberParser();
        }

        public static SubscriberParser CreateUsualParser()
        {
            return new UsualSubscriberParser();
        }
    }
}