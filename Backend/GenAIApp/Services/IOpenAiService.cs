namespace GenAIApp.Services
{
    public interface IOpenAiService
    {
         Task<string> GenrateFormattedContentAsync(string input, string outputType);
    }
}