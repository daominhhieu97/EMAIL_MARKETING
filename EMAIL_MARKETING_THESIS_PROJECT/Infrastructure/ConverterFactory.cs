namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class ConverterFactory
    {
        public static RFMModelConverter CreateRFMConverter()
        {
            return new RFMModelConverter();
        }

        public static UsualConverter CreateUsualConverter()
        {
            return new UsualConverter();
        }
    }
}