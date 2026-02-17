namespace AICodeReviewer.Services.V2
{
    public class PromptBuilderV2
    {
        public static string Build(string code, List<string> staticIssues)
        {
            return $"""
You are a senior .NET code reviewer.

Static analysis findings:
{string.Join("\n", staticIssues)}

Now deeply review the following C# code.

Focus on:
- Architecture
- SOLID
- Maintainability
- Hidden design issues

Return structured response.

Code:
{code}
""";
        }

    }
}
