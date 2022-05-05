using System.ComponentModel.DataAnnotations;

namespace EasyJob.API.Payments.Resources
{
    public class SavePaymentResource
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Required]
        public int Cost { get; set; }
    }
}