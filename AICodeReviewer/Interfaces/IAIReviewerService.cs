namespace AICodeReviewer.Interfaces
{
    public interface IAIReviewerService
    {
        Task<string> ReviewV1Async(string code);
        Task<string> ReviewV2Async(string code);
    }
}
