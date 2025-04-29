using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Web.Models
{
    public class AddStudentViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email must contain '@' and be valid.")]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public bool Subscribed { get; set; }
    }
}
