namespace AICodeReviewer.Models
{
    public class CodeReviewRequest
    {
        public string Code { get; set; } = string.Empty;
        public string Language { get; set; } = "C#";
        public string ReviewType { get; set; } = "clean-code";
    }
}
