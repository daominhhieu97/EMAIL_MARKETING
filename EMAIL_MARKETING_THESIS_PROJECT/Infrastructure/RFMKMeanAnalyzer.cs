using System.Collections.Generic;
using System.IO;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class RFMKMeanAnalyzer : IKmeanCustomerAnalyzer
    {
        public List<RFMSubscriber> Analyze(MailingList mailingList, string subscriberRateClass)
        {
            const string path = @"C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\RFMFiles\rfm-table.csv";

            var subscribers = new List<RFMSubscriber>();

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (line == null) continue;

                    var values = line.Split(',');
                    var rFmSubscriber = new RFMSubscriber
                    {
                        Name = values[0],
                        Email = values[1],
                        Age = int.Parse(values[2]),
                        Phone = values[3],
                        City = values[4],
                        FClass = int.Parse(values[8]),
                        RClass = int.Parse(values[9]),
                        MClass = int.Parse(values[10]),
                        RFMClass = values[11]
                    };

                    if (rFmSubscriber.RFMClass.Equals(subscriberRateClass))
                        subscribers.Add(rFmSubscriber);
                }
            }

            return subscribers;
        }
    }
}