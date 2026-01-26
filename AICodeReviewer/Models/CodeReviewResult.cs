namespace AICodeReviewer.Models
{
    public class CodeReviewResult
    {
        public string Summary { get; set; } = string.Empty;
        public List<string> Issues { get; set; } = [];
        public List<string> Suggestions { get; set; } = [];
        public int Score { get; set; }
    }
}
