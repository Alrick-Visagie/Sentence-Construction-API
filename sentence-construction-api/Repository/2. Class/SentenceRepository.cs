using SentenceConstruction.Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace SentenceConstruction.Repository
{
    public class SentenceRepository : ISentenceRepository
    {
        private readonly SentenceConstructionDbContext _sentenceConstructionDbContext;
        public SentenceRepository(SentenceConstructionDbContext sentenceConstructionDbContext) 
        {
            _sentenceConstructionDbContext = sentenceConstructionDbContext;
        }
        public IEnumerable<Sentences> GetSentenceList()
        {
            return _sentenceConstructionDbContext.Sentences.AsEnumerable();
        }

        public void SaveSentence(Sentences sentence)
        {
            _sentenceConstructionDbContext.Sentences.Add(sentence);
            _sentenceConstructionDbContext.SaveChanges();
        }

        public void DeleteSentence(string sentenceId)
        {
            var result = _sentenceConstructionDbContext.Sentences.Find(sentenceId);
            _sentenceConstructionDbContext.Sentences.Remove(result);
            _sentenceConstructionDbContext.SaveChanges();
        }
    }
}
