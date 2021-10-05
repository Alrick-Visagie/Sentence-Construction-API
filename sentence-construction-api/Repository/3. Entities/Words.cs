using System.ComponentModel.DataAnnotations;

namespace SentenceConstruction.Repository.Models
{
    public class Words
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Word { get; set; }
    }
}
