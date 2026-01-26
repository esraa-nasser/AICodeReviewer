using AICodeReviewer.Models;
using AICodeReviewer.Services;
using Microsoft.AspNetCore.Mvc;

namespace AICodeReviewer.Controllers
{
    [ApiController]
    [Route("api/code-review")]
    public class CodeReviewController : ControllerBase
    {
        private readonly AiReviewerService _service;

        public CodeReviewController(AiReviewerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Review(CodeReviewRequest request)
        {
            var result = await _service.ReviewAsync(request.Code);
            return Ok(result);
        }
    }
}
