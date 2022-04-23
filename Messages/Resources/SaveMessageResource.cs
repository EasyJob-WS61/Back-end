
using System.ComponentModel.DataAnnotations;

namespace EasyJob.API.Messages.Resources



{
    public class SaveMessageResource
    {
        [Required]
        [MaxLength(25)]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public int Description { get; set; }
        
        [Required]
        [MaxLength(120)]
        public string Date { get; set; }
        
       
    }
    
    
}