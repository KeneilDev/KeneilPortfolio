using System.ComponentModel.DataAnnotations;

namespace KeneilPortfolio.Models
{
    public class ContactForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
