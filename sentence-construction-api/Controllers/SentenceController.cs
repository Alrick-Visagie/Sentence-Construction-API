using Microsoft.AspNetCore.Mvc;
using SentenceConstruction.Models;
using SentenceConstruction.Serices;
using System.Collections.Generic;

namespace SentenceConstruction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentenceController : ControllerBase
    {
        private readonly ISentenceService _sentenceService;
        public SentenceController(ISentenceService sentenceService)
        {
            _sentenceService = sentenceService;
        }

        [HttpGet("get-sentences")]
        public List<SentenceDto> GetSentences()
        {
            return _sentenceService.GetSentences();
        }

        [HttpPost("save-sentence")]
        public void SaveSentence(SentenceDto sentence)
        {
             _sentenceService.SaveSentence(sentence);
        }
        
        [HttpDelete("delete-sentence")]
        public void DeleteSentence([FromQuery]string sentenceId)
        {
            _sentenceService.DeleteSentence(sentenceId);
        }
    }
}
