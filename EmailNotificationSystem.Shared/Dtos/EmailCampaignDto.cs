namespace EmailNotificationSystem.Shared.Dtos;

public class EmailCampaignDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Status { get; set; }
}