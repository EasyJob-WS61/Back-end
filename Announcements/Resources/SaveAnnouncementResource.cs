using System.ComponentModel.DataAnnotations;

namespace EasyJob.API.Announcements.Resources
{
    public class SaveAnnouncementResource
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(350)]
        public string Description { get; set; }
        
        [Required]
        public double Salary { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string Date { get; set; }
        [Required]
        public int Visible { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Place { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Ability { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Period { get; set; }
    }
}