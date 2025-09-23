using System.ComponentModel.DataAnnotations;

namespace asptraining.Models
{
    public class Developer
    {
        [Key]
        public int DevID { get; set; }
        public string DevFirstName { get; set; }
        public string DevLastName { get; set; }
        public string DevMiddleName {get;set;}
        public string Specialty { get; set; }
        public bool IsActive { get; set; }
        public DateTime HireDate { get; set; }

    }
}
