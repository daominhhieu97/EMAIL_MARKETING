using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using Sub = EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;

using System.IO;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public class RFMKMeanAnalyzer : IKmeanCustomerAnalyzer
    {
        public List<RFMSubscriber> Analyze(MailingList mailingList, string subscriberRateClass)
        {
            var path = @"C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\RFMFiles\rfm-segmentation.csv";
            var subscribers = new List<RFMSubscriber>();

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    RFMSubscriber rFMSubscriber = new RFMSubscriber
                    {
                        Age = 10,
                        Area = "asdfa",
                        City = "adadf",
                        Email = "hieudm97@gmail.com",
                        FClass = int.Parse(values[5]),
                        RClass = int.Parse(values[4]),
                        MClass = int.Parse(values[6]),
                        Name = values[0],
                        RFMClass = values[7],
                        Phone = "0925098044"
                    };

                    if (rFMSubscriber.RFMClass.Equals(subscriberRateClass))
                        subscribers.Add(rFMSubscriber);
                }
            }

            return subscribers;
        }

        private List<RFMSubscriber> GetSubscribers(object file, string subscriberRateClass)
        {
            throw new NotImplementedException();
        }

        private object GetRFMFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}