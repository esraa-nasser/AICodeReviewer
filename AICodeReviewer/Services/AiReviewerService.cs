using AICodeReviewer.Interfaces;
using AICodeReviewer.Services.V1;
using AICodeReviewer.Services.V2;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace AICodeReviewer.Services
{
    public class AiReviewerService : IAIReviewerService
    {
        private readonly OllamaClient _ollama;
        private readonly IRoslynAnalyzerService _roslynAnalyzerService;

        public AiReviewerService(OllamaClient ollama, IRoslynAnalyzerService roslynAnalyzerService)
        {
            _ollama = ollama;
            _roslynAnalyzerService = roslynAnalyzerService;
        }

        public async Task<string> ReviewV1Async(string code)
        {
            var prompt = PromptBuilder.Build(code);
            return await _ollama.AskAsync(prompt);
        }
        public async Task<string> ReviewV2Async(string code)
        {
            var staticIssues = _roslynAnalyzerService.Analyze(code);

            var prompt = PromptBuilderV2.Build(code, staticIssues);

            var aiResponse = await _ollama.AskAsync(prompt);

            return aiResponse;
        }
    }

}
