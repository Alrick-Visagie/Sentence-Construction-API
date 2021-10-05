using SentenceConstruction.Models;
using System.Collections.Generic;

namespace SentenceConstruction.Serices
{
    public interface ISentenceService
    {
        List<SentenceDto> GetSentences();
        void SaveSentence(SentenceDto sentence);
        void DeleteSentence(string sentenceId);
    }
}