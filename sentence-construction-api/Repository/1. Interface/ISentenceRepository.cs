using SentenceConstruction.Repository.Models;
using System.Collections.Generic;

namespace SentenceConstruction.Repository
{
    public interface ISentenceRepository
    {
        IEnumerable<Sentences> GetSentenceList();
        void SaveSentence(Sentences sentence);
        void DeleteSentence(string sentenceId);
    }
}