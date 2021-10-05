using System.ComponentModel.DataAnnotations;

namespace SentenceConstruction.Repository.Models
{
    public class Sentences
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string Sentence { get; set; }
    }
}
