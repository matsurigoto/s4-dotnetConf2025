using dotnetConf2025.Shared.Models;
using dotnetConf2025.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetConf2025.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpeakerController : ControllerBase
    {
        private readonly ILogger<SpeakerController> _logger;
        private readonly SpeakerService _speakerService;

        public SpeakerController(ILogger<SpeakerController> logger, SpeakerService speakerService)
        {
            _logger = logger;
            _speakerService = speakerService;
        }

        // GET /api/speaker
        [HttpGet]
        public IEnumerable<SpeakerModel> Get()
        {
            return _speakerService.GetSpeakers()
                .Where(p => p.Tags.Contains("HackMD"));
        }
    }
}