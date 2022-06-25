using EasyJob.API.Applicants.Domain.Models;

namespace EasyJob.API.Announcements.Domain.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Salary { get; set; }
        public string Date { get; set; }
        public int Visible { get; set; }

        public string Photo { get; set; }

        public int ApplicantId { get; set; }
        
        public string Place { get; set; }
        public string Ability { get; set; }
        public string Period { get; set; }
        
    }
}