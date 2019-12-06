using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class EmailSender
    {
        private readonly ProjectContext context;

        public EmailSender(ProjectContext context)
        {
            this.context = context;
        }

        public async Task SendEmail(Campaign campaign)
        {
            var mailingList = campaign.MailingList;

            var subscribers = context.Set<MailingListSubscriber>()
                .Where(ms => ms.MailingListId == mailingList.Id)
                .Select(ms => ms.Subscriber)
                .ToList();

            var sendOn = campaign.Scheduler.SendOn ?? campaign.Scheduler.SendOn;

            foreach (var subscriber in subscribers)
            {
                try
                {
                    var message = CreateMimeMessage(campaign, subscriber);
                    message.Body = CreateMessageBody();

                    var client = new SmtpClient();
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("hieudm97@gmail.com", "hieudm231197");
                    await client.SendAsync(message);
                    client.Disconnect(true);
                    client.Dispose();
                    break;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private static MimeEntity CreateMessageBody()
        {
            var bodyBuilder = new BodyBuilder
            {
                TextBody = "Hello World!"
            };

            return bodyBuilder.ToMessageBody();
        }

        private static MimeMessage CreateMimeMessage(Campaign campaign, Subscriber subscriber)
        {
            var message = new MimeMessage();

            var from = new MailboxAddress(campaign.EmailInfo.Name, campaign.EmailInfo.Sender);
            message.From.Add(from);

            var to = new MailboxAddress(subscriber.Name, subscriber.Email);
            message.To.Add(to);

            message.Subject = campaign.EmailInfo.Subject;

            if (campaign.Scheduler.SendOn != null)
                message.Date = (DateTimeOffset)campaign.Scheduler.SendOn;

            return message;
        }
    }
}