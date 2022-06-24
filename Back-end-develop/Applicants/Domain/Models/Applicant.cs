namespace EasyJob.API.Applicants.Domain.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; } //ok
        public string Ruc { get; set; }
        public string Website { get; set; }
        public string Email { get; set; } //ok
        public string Password { get; set; } //ok
        public string Photo { get; set; } //ok
    }
}