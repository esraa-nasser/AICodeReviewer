namespace AICodeReviewer.Services.V1
{
    public static class PromptBuilder
    {
        public static string Build(string code)
        {
            return $"""
You are a senior .NET code reviewer.

Review the following C# code.
Focus on:
- Clean Code
- SOLID principles
- Readability
- Maintainability

Return:
1. Summary
2. List of issues
3. Suggestions
4. Score from 1 to 10

C# Code:
{code}
""";
        }
    }

}
