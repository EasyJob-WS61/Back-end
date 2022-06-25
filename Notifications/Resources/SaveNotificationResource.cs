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
        [MaxLength(100)] 
        public string State { get; set; }
        
        [Required] 
        public int ApplicantId { get; set; }
        
        [Required] 
        public int Announcement_Id { get; set; }
        
        [Required] 
        public int Postulant_Id { get; set; }
        
        [Required] 
        [MaxLength(200)] 
        public string Feedback { get; set; }
    }
}