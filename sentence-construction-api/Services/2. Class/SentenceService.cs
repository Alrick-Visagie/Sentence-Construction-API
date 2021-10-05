using SentenceConstruction.Mappers;
using SentenceConstruction.Models;
using SentenceConstruction.Repository;
using System.Collections.Generic;

namespace SentenceConstruction.Serices
{
    public class SentenceService : ISentenceService
    {
        private readonly ISentenceRepository _sentenceRepository;
        public SentenceService(ISentenceRepository sentenceRepository) 
        {
            _sentenceRepository = sentenceRepository;
        }
     
        public List<SentenceDto> GetSentences()
        {
            var sentence = _sentenceRepository.GetSentenceList();
            return SentenceMapper.Map(sentence);
        }

        public void SaveSentence(SentenceDto sentence)
        {
            var result = SentenceMapper.Map(sentence);
            _sentenceRepository.SaveSentence(result);
        }

        public void DeleteSentence(string sentenceId)
        {
            _sentenceRepository.DeleteSentence(sentenceId);
        }
    }
}
