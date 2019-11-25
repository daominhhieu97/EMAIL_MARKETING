using System.Collections.Generic;

namespace RFM_Console.Models
{
    public class Cluster
    {
        public string Title { get; set; }

        public List<Subscriber> Subscribers { get; set; }
    }
}
