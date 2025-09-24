using System.ComponentModel.DataAnnotations;

namespace asptraining.Models
{
    public class Developer
    {
        [Key]
        public int DevID { get; set; }
        [Required(ErrorMessage ="Please provide Firstname")]
        [StringLength(1019,MinimumLength =3, ErrorMessage ="Firstname Must be Between 3 to 1019 characters")]
        public string DevFirstName { get; set; }
        [Required(ErrorMessage = "Please provide Lastname")]
        [StringLength(747, MinimumLength = 3, ErrorMessage = "Lastname Must be Between 3 to 747 characters")]
        public string DevLastName { get; set; }
        [StringLength(747, MinimumLength = 3, ErrorMessage = "Middlename Must be Between 3 to 747 characters")]
        [Required(ErrorMessage = "Please provide Middlename")]
        public string DevMiddleName {get;set;}
        [Required(ErrorMessage = "Please provide Specialty")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Specialty Must be Between 3 to 50 characters")]
        public string Specialty { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Please provide Hiredate")]
        public DateTime HireDate { get; set; }

    }
}
