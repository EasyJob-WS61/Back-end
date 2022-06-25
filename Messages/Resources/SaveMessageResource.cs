
using System.ComponentModel.DataAnnotations;

namespace EasyJob.API.Messages.Resources



{
    public class SaveMessageResource
    {
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        
        [Required]
        public int fromApplicant { get; set; }
        
        [Required]
        public int Postulant_Id { get; set; }
        
        [Required]
        public int Applicant_Id { get; set; }
        
        [Required]
        [MaxLength(120)]
        public string Date { get; set; }
        
        [Required]
        [MaxLength(220)]
        public string Text { get; set; }
    }
    
    
}