using AICodeReviewer.Interfaces;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace AICodeReviewer.Services
{
    public class RoslynAnalyzerService : IRoslynAnalyzerService
    {
        public List<string> Analyze(string code)
        {
            var tree = CSharpSyntaxTree.ParseText(code);
            var compilation = CSharpCompilation.Create("Analysis")
                .AddSyntaxTrees(tree)
                .AddReferences(
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location));

            var diagnostics = compilation.GetDiagnostics();

            return diagnostics
                .Where(d => d.Severity == DiagnosticSeverity.Warning ||
                            d.Severity == DiagnosticSeverity.Error)
                .Select(d => d.GetMessage())
                .ToList();

        }
    }
}
