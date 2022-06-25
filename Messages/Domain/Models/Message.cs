namespace EasyJob.API.Messages.Domain.Models
{
    public class Message
    {
        public int Id { get; set; }
        
        public int fromApplicant { get; set; }
        
        public int Postulant_Id { get; set; }
       
        public int Applicant_Id { get; set; }
        public string Date { get; set; }
        public string Text { get; set; }
    }
}
