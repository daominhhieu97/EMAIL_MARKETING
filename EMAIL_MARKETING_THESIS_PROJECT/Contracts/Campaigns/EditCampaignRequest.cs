namespace EMAIL_MARKETING_THESIS_PROJECT.Contracts.Campaigns
{
    public class EditCampaignRequest
    {
        public int CampaignId { get; internal set; }
        public object EditParts { get; internal set; }
    }
}