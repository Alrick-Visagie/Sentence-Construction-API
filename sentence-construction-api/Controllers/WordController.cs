using Microsoft.AspNetCore.Mvc;
using SentenceConstruction.Models;
using SentenceConstruction.Serices;

namespace SentenceConstruction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IWordService _wordService;
        public WordController(IWordService wordService)
        {
            _wordService = wordService;
        }

        [HttpGet("get-words")]
        public WordDto GetWords()
        {
            return _wordService.GetWords();
        }
    }
}
