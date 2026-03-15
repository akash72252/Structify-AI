namespace GenAIApp.Services
{
    public interface IWhisperService
    {
        Task<string> TranscribeAudioAsync(string filePath);
    }
}