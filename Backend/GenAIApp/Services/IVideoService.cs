namespace GenAIApp.Services
{
   public  interface IVideoService
    {
        Task<string> ExtractAudioAndTranscribeAsync(string videoPath);
    }
}