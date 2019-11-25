using System;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models
{
    public class Scheduler
    {
        public bool IsSendNow { get; set; }

        public DateTime SendOn { get; set; }
    }
}
