namespace EasyJob.API.Payments.Domain.Models
{
    public class Payment
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public int Cost { get; set; }
    }
}