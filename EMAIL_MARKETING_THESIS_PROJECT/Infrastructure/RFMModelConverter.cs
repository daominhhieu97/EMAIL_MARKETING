using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using Microsoft.AspNetCore.Http;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class RFMModelConverter : SystemConverter
    {
        #region Overrides of SystemConverter

        public override async Task<List<RFMSubscriber>> Convert(IFormFile file)
        {
            var subscriberCsvString = await SystemConverter.ReadFromCsvFile(file.OpenReadStream());

            var customersData = subscriberCsvString
                .Split(new[] { "\r\n", "\r", "\n" },
                    StringSplitOptions.None)
                .Select(sub => sub).ToList();

            var list = new List<RFMSubscriber>();

            foreach (var customer in customersData)
            {
                if (string.IsNullOrEmpty(customer))
                    break;

                if (customer.Contains("Name"))
                    continue;

                var customerInfo = customer.Split(",");

                try
                {
                    if (CustomerInfoIsValidForRFMModel(customerInfo))
                    {
                        var sub = new RFMSubscriber
                        {
                            Name = customerInfo[1].Trim(),
                            Email = customerInfo[2].Trim(),
                            Phone = customerInfo[3].Trim(),
                            Age = string.IsNullOrEmpty(customerInfo[4].Trim()) ? 0 : int.Parse(customerInfo[4].Trim()),
                            Area = customerInfo[5].Trim(),
                            City = customerInfo[6].Trim(),
                            Monetary = string.IsNullOrEmpty(customerInfo[7].Trim()) ? 0 : float.Parse(customerInfo[7].Trim()),
                            Recency = string.IsNullOrEmpty(customerInfo[8].Trim()) ? 0 : float.Parse(customerInfo[8].Trim()),
                            Frequency = string.IsNullOrEmpty(customerInfo[9].Trim()) ? 0 : float.Parse(customerInfo[9].Trim()),
                            RFMClass = customerInfo[11].Trim()
                        };
                        list.Add(sub);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return list;
        }

        #endregion Overrides of SystemConverter

        private bool CustomerInfoIsValidForRFMModel(string[] customerInfo)
        {
            return !string.IsNullOrEmpty(customerInfo[7].Trim())
                   && !string.IsNullOrEmpty(customerInfo[8].Trim())
                   && !string.IsNullOrEmpty(customerInfo[9].Trim())
                   && !string.IsNullOrEmpty(customerInfo[11].Trim());
        }
    }
}