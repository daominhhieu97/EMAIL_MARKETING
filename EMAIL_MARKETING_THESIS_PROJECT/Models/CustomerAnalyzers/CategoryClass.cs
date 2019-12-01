namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public abstract class CategoryClass
    {
        public  string Champion;

        public string NeedToTakeCare;

        public string NormalCustomer;
    }

    public class RFMCategoryClass : CategoryClass
    {
        public const string Champion = "144";

        public const string NeedToTakeCare = "111";

        public const string NormalCustomer = "222";
    }

    public class IncomeCategoryClass : CategoryClass
    {

    }
}