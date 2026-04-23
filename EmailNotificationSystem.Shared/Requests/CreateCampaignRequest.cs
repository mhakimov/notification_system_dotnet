namespace EmailNotificationSystem.Shared.Requests;

public class CreateCampaignRequest
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}