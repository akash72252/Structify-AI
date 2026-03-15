using Xabe.FFmpeg;

namespace GenAIApp.Services
{
    public class VideoService: IVideoService
    {
        private readonly IWhisperService _whisperService;
        public VideoService(IWhisperService whisperService)
        {
            _whisperService=whisperService;
            FFmpeg.SetExecutablesPath("ffmpeg_bin_path");
        }

        public async Task<string> ExtractAudioAndTranscribeAsync(string videoPath)
        {
            var audioPath=Path.ChangeExtension(videoPath, ".mp3");
            var conversion=await FFmpeg.Conversions.FromSnippet.ExtractAudio(videoPath, audioPath);
            await conversion.Start();
            return await _whisperService.TranscribeAudioAsync(audioPath);
        }
    }
}
