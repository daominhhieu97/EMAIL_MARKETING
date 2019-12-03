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

            foreach (var subscriber in subscribers)
            {
                try
                {
                    MimeMessage message = CreateMimeMessage(campaign, subscriber);
                    message.Body = CreateMessageBody();

                    SmtpClient client = new SmtpClient();
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

        private MimeEntity CreateMessageBody()
        {
            BodyBuilder bodyBuilder = new BodyBuilder
            {
                TextBody = "Hello World!"
            };

            return bodyBuilder.ToMessageBody();
        }

        private MimeMessage CreateMimeMessage(Campaign campaign, Subscriber subscriber)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress(campaign.EmailInfo.Name, campaign.EmailInfo.Sender);
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress(subscriber.Name, subscriber.Email);
            message.To.Add(to);

            message.Subject = campaign.EmailInfo.Subject;

            return message;
        }
    }
}