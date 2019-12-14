using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMAIL_MARKETING_THESIS_PROJECT.Views.Common
{
    public class RFMSegments
    {
        public static Dictionary<string, string> Segments => new Dictionary<string, string>
        {
            { "Bests Customers", "111"},
            { "High-spending New Customers", "142" },
            { "Lowest-Spending Active Loyal Customers", "113"},
            { "Churned Best Customers", "411"}
        };

        public static SelectListItem[] GetRFMSegments => Segments.Select(s => new SelectListItem { Text = s.Key, Value = s.Value }).ToArray();
    }
}