﻿namespace EasyJob.API.Projects.Domain.Models
{
    public class Project {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Photo { get; set; }
        public int Postulants_id { get; set; }
       
    }
}