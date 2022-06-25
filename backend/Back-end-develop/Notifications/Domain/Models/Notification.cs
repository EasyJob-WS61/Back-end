﻿using System;

namespace EasyJob.API.Notifications.Domain.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        
        public string State { get; set; }
        
        public int ApplicantId { get; set; }
        
        public int Announcement_Id { get; set; }
        
        public int Postulant_Id { get; set; }
        public string Feedback { get; set; }
    }
}