using SentenceConstruction.Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace SentenceConstruction.Repository
{
    public class WordRepository : IWordRepository
    {
        private readonly SentenceConstructionDbContext _sentenceConstructionDbContext;
        public WordRepository(SentenceConstructionDbContext sentenceConstructionDbContex)
        {
            _sentenceConstructionDbContext = sentenceConstructionDbContex;
        }
        public IEnumerable<Words> GetWordList()
        {
            return _sentenceConstructionDbContext.Words.AsEnumerable();
        }
    }
}
