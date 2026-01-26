namespace AICodeReviewer.Services
{
    public class AiReviewerService
    {
        private readonly OllamaClient _ollama;

        public AiReviewerService(OllamaClient ollama)
        {
            _ollama = ollama;
        }

        public async Task<string> ReviewAsync(string code)
        {
            var prompt = PromptBuilder.Build(code);
            return await _ollama.AskAsync(prompt);
        }
    }

}
