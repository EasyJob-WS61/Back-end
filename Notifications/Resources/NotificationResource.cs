namespace EasyJob.API.Notifications.Resources
{
    public class NotificationResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Feedback { get; set; }
        public int PostulantId { get; set; }
        public int ApplicantId { get; set; }
        public int AnnouncementId { get; set; }
    }
}