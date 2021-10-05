using SentenceConstruction.Models;
using SentenceConstruction.Repository.Models;
using System.Collections.Generic;

namespace SentenceConstruction.Mappers
{
    public static class WordMapper
    {
        public static WordDto Map(IEnumerable<Words> words)
        {
            var result = new WordDto();

            foreach (var word in words) 
            {
                if (word.Name == nameof(WordListType.Nouns))
                    result.Nouns = new List<string>(word.Word.Split(','));

                if (word.Name == nameof(WordListType.Verbs))
                    result.Verbs = new List<string>(word.Word.Split(','));

                if (word.Name == nameof(WordListType.Adjectives))
                    result.Adjectives = new List<string>(word.Word.Split(','));

                if (word.Name == nameof(WordListType.Adverbs)) 
                    result.Adverbs = new List<string>(word.Word.Split(','));

                if (word.Name == nameof(WordListType.Pronouns))
                    result.Pronouns = new List<string>(word.Word.Split(','));

                if (word.Name == nameof(WordListType.Prepositions))
                    result.Prepositions = new List<string>(word.Word.Split(','));

                if (word.Name == nameof(WordListType.Conjunctions))
                    result.Conjunctions = new List<string>(word.Word.Split(','));

                if (word.Name == nameof(WordListType.Determiners))
                    result.Determiners = new List<string>(word.Word.Split(','));

                if (word.Name == nameof(WordListType.Exclamations))
                    result.Exclamations = new List<string>(word.Word.Split(','));
            }

            return result;
        }
    }
}
