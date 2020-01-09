using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.Controllers;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using Microsoft.AspNetCore.Http;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class UsualConverter : SystemConverter
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

                if (CustomerInfoIsValid(customerInfo))
                {
                    var sub = new RFMSubscriber
                    {
                        Name = customerInfo[1].Trim(),
                        Email = customerInfo[2].Trim(),
                        Phone = customerInfo[3].Trim(),
                        Age = string.IsNullOrEmpty(customerInfo[4].Trim()) ? 0 : int.Parse(customerInfo[4].Trim()),
                        Area = customerInfo[5].Trim(),
                        City = customerInfo[6].Trim()
                    };
                    list.Add(sub);
                }
            }

            return list;
        }

        #endregion Overrides of SystemConverter

        private bool CustomerInfoIsValid(string[] customerInfo)
        {
            return !string.IsNullOrEmpty(customerInfo[1])
                   && !string.IsNullOrEmpty(customerInfo[2])
                   && !string.IsNullOrEmpty(customerInfo[3]);
        }
    }
}