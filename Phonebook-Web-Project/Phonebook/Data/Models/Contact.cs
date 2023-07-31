using System.ComponentModel.DataAnnotations;

namespace Phonebook.Data.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
