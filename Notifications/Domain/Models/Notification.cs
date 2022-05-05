using System;
using EasyJob.API.Announcements.Domain.Models;
using EasyJob.API.Applicants.Domain.Models;
using EasyJob.API.Postulants.Domain.Models;

namespace EasyJob.API.Notifications.Domain.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        
        public string Feedback { get; set; }
        public Postulant Postulant { get; set; }
        public int PostulantId { get; set; }
        public Applicant Applicant { get; set; }
        public int ApplicantId { get; set; }
        
        public Announcement Announcement { get; set; }
        
        public int AnnouncementId { get; set; }
    }
}