using SentenceConstruction.Repository.Models;
using System.Collections.Generic;

namespace SentenceConstruction.Repository
{
    public interface IWordRepository
    {
        IEnumerable<Words> GetWordList();
    }
}