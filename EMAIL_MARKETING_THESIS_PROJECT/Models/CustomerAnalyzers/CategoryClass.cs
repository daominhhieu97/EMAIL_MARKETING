namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public abstract class CategoryClass
    {
        public string Champion;

        public string NeedToTakeCare;

        public string NormalCustomer;
    }

    public class RFMCategoryClass : CategoryClass
    {
        public string Champion => "444";

        public string NeedToTakeCare => "111";

        public string NormalCustomer => "222";
    }

    public class IncomeCategoryClass : CategoryClass
    {

    }
}