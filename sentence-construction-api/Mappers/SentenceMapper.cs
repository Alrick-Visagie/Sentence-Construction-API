using SentenceConstruction.Models;
using SentenceConstruction.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentenceConstruction.Mappers
{
    public static class SentenceMapper
    {
        public static List<SentenceDto> Map(IEnumerable<Sentences> sentences) 
        {
            var result = new List<SentenceDto>();

            foreach (var s in sentences)
            {
                var item = new SentenceDto
                {
                    ID = s.ID,
                    Sentence = s.Sentence                  
                };

                result.Add(item);
            }

            return result;
        }

        public static Sentences Map(SentenceDto sentences)
        {
            return new Sentences
            {
                ID = Guid.NewGuid().ToString(),
                Sentence = sentences.Sentence
            };
        }
    }
}
