# AI Code Reviewer (Local .NET Web API)

![GitHub Repo stars](https://img.shields.io/github/stars/esraa-nasser/AICodeReviewer?style=social)
![GitHub forks](https://img.shields.io/github/forks/esraa-nasser/AICodeReviewer?style=social)
![GitHub issues](https://img.shields.io/github/issues/esraa-nasser/AICodeReviewer)
![GitHub license](https://img.shields.io/github/license/esraa-nasser/AICodeReviewer)

## Overview
**AI Code Reviewer** is a **local .NET Web API** that uses a **local AI agent (LLaMA3 via Ollama)** to automatically review C# code.  
It generates **structured feedback**: summary, list of issues, suggestions, and a quality score.

This project demonstrates **AI integration in .NET** combining **LLM reasoning** with **Roslyn code analysis** for maintainable and professional code reviews.

---

## Features
- ✅ Review C# code for **Clean Code & SOLID principles**  
- ✅ Generates **Summary, Issues, Suggestions, Score**  
- ✅ Fully **local AI** (no cloud API keys)  
- ✅ Extendable for **Security**, **Performance**, or **Custom Review Rules**  
- ✅ REST API endpoint for Postman, Frontend, or CI/CD pipelines  

---

## Tech Stack
- **Backend**: .NET 8 Web API  
- **AI Model**: LLaMA3 (via Ollama, Local Deployment)  
- **Code Analysis**: Roslyn (optional pre-checks)  
- **Language**: C#  

---

## Getting Started

### Prerequisites
- Windows 10/11 (or Linux/macOS with .NET 8)  
- .NET 8 SDK  
- Ollama installed ([https://ollama.com](https://ollama.com))  
- Minimum **8GB RAM** (16GB recommended)  

---

### Quick Setup
```bash
# Clone repo
git clone https://github.com/YourUsername/ai-code-reviewer.git
cd ai-code-reviewer

# Pull AI model
ollama pull llama3

# Run the Web API
dotnet run

POST /api/code-review
Request Sample
{
  "code": "public class Test { public void Do() { Console.WriteLine(\"hi\"); } }",
  "language": "C#",
  "reviewType": "clean-code"
}

Response
{
  "summary": "Simple Test class, needs better naming, comments, and validation.",
  "issues": [
    "Namespace missing",
    "Class name too generic",
    "Method name too generic",
    "No comments",
    "No parameter validation"
  ],
  "suggestions": [
    "Add meaningful namespace",
    "Rename class and method to descriptive names",
    "Add comments",
    "Implement basic parameter validation"
  ],
  "score": 5
}
Project Structure
/AiCodeReviewer.Api
 ├── Controllers
 │    └── CodeReviewController.cs
 ├── Services
 │    ├── AiReviewerService.cs
 │    ├── PromptBuilder.cs
 │    └── OllamaClient.cs
 ├── Models
 │    ├── CodeReviewRequest.cs
 │    └── CodeReviewResult.cs
 └── Program.cs

Next Steps / Enhancements
  Add Roslyn static analysis pre-checks
  Add Security review mode
  Add Performance review mode
  Save review history to database
  Implement structured JSON parsing for frontend or CI/CD integration

Notes
  Works fully local, no cloud keys required
  Ollama must be running for AI responses
  Designed to be extensible for any C# review scenario
