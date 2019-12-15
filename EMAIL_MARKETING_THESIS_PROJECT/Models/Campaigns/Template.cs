using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class Template
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string Content { get; set; }
    }
}