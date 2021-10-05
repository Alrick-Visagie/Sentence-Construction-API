using SentenceConstruction.Mappers;
using SentenceConstruction.Models;
using SentenceConstruction.Repository;

namespace SentenceConstruction.Serices
{
    public class WordService : IWordService
    {
        private readonly IWordRepository _wordRepository;
        public WordService(IWordRepository wordRepository)
        {
            _wordRepository = wordRepository;
        }
        public WordDto GetWords()
        {
            var result = _wordRepository.GetWordList();

            return WordMapper.Map(result);
        }
    }
}
