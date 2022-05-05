using System.ComponentModel.DataAnnotations;

namespace EasyJob.API.Notifications.Resources
{
    public class SaveNotificationResource
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string Date { get; set; }
        
        [Required]
        [MaxLength(500)]
        public string Feedback { get; set; }
        
        [Required]
        public int ApplicantId { get; set; }
        
        [Required]
        public int PostulantId { get; set; }
        
        [Required]
        public int AnnouncementId { get; set; }

    }
}