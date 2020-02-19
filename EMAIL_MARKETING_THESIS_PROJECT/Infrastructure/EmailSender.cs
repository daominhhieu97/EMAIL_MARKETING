using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            var segment = context.Set<Segment>().Include(s => s.Subscribers).Single(s => s.Id == campaign.SegmentId);
            var subscribers = segment.Subscribers;

            var client = new SmtpClient();

            client.Connect("smtp.gmail.com", 465, true);
            client.Authenticate("hieudm97@gmail.com", "hieudm231197");

            foreach (var subscriber in subscribers)
            {
                var message = CreateMimeMessage(campaign, subscriber);
                message.Body = CreateMessageBody(campaign.EmailInfo.Template);

                await client.SendAsync(message);
            }

            client.Disconnect(true);

            client.Dispose();
        }

        private static MimeEntity CreateMessageBody(Template template)
        {
            var bodyBuilder = new BodyBuilder();

            bodyBuilder.HtmlBody = template.Content;

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
                message.ResentDate = (DateTimeOffset)campaign.Scheduler.SendOn;

            return message;
        }
    }
}