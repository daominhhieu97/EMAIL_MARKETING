using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMAIL_MARKETING_THESIS_PROJECT.Views.Common
{
    public class RFMSegments
    {
        public static string[] Segments => new string[]
        {
            "Hibernating",
            "Need Attention",
            "Lost",
            "Sleep",
            "Champion",
            "Potential",
            "Recent",
            "Promising",
            "Risk",
            "Can't Lose",
            "Loyal"
        };

        public static SelectListItem[] GetRFMSegments => Segments.Select(s => new SelectListItem { Text = s, Value = s }).OrderBy(x => x.Text).ToArray();
    }
}