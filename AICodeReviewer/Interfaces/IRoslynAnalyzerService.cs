namespace AICodeReviewer.Interfaces
{
    public interface IRoslynAnalyzerService
    {
        List<string> Analyze(string code);
    }
}
