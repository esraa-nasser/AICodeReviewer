namespace AICodeReviewer.Services
{
    public class OllamaClient
    {
        private readonly HttpClient _http;

        public OllamaClient(HttpClient http)
        {
            _http = http;
            _http.BaseAddress = new Uri("http://localhost:11434/");
        }

        public async Task<string> AskAsync(string prompt)
        {
            var payload = new
            {
                model = "llama3",
                prompt = prompt,
                stream = false
            };

            var response = await _http.PostAsJsonAsync("api/generate", payload);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<OllamaResponse>();
            return result?.response ?? "";
        }
    }

    public class OllamaResponse
    {
        public string response { get; set; } = "";
    }

}
