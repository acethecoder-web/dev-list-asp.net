using System.ComponentModel.DataAnnotations;

namespace asptraining.Models
{
    public class Developer
    {
        [Key]
        public int DevID { get; set; }
        [Required]
        public string DevFirstName { get; set; }
        [Required]
        public string DevLastName { get; set; }
        [Required]
        public string DevMiddleName {get;set;}
        [Required]
        public string Specialty { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public DateTime HireDate { get; set; }

    }
}
