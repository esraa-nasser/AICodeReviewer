using AICodeReviewer.Interfaces;
using AICodeReviewer.Models;
using AICodeReviewer.Services;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace AICodeReviewer.Controllers.V2
{
    [ApiController]
    [Route("api/v{version:apiVersion}/review")]
    [ApiVersion("2.0")]
    public class CodeReviewController : ControllerBase
    {
        private readonly IAIReviewerService _service;

        public CodeReviewController(IAIReviewerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Review(CodeReviewRequest request)
        {
            var result = await _service.ReviewV2Async(request.Code);
            return Ok(result);
        }
    }
}
