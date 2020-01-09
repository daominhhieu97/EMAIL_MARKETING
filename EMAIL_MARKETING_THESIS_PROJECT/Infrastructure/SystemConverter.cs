using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using Microsoft.AspNetCore.Http;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public abstract class SystemConverter
    {
        public abstract Task<List<RFMSubscriber>> Convert(IFormFile file);

        public static async Task<string> ReadFromCsvFile(Stream openReadStream)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(openReadStream))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(await reader.ReadLineAsync());
            }
            return result.ToString();
        }
    }
}