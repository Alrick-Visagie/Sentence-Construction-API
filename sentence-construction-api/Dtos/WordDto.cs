using System.Collections.Generic;

namespace SentenceConstruction.Models
{
    public class WordDto
    {
        public List<string> Nouns { get; set; }
        public List<string> Verbs { get; set; }
        public List<string> Adjectives { get; set; }
        public List<string> Adverbs { get; set; }
        public List<string> Pronouns { get; set; }
        public List<string> Prepositions { get; set; }
        public List<string> Conjunctions { get; set; }
        public List<string> Determiners { get; set; }
        public List<string> Exclamations { get; set; }
    }
}
