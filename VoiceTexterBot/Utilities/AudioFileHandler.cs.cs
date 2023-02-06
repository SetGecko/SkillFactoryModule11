using VoiceTexterBot.Configuration;
using VoiceTexterBot.Utilities;

namespace VoiceTexterBot.Utilities
{
    internal class AudioFileHandler
    {
        AppSettings _appSettings = new AppSettings();

        public string Process(string inputParam)
        {
            string inputAudioPath = Path.Combine(_appSettings.DownloadsFolder, $"{_appSettings.AudioFileName}.{_appSettings.InputAudioFormat}");
            string outputAudioPath = Path.Combine(_appSettings.DownloadsFolder, $"{_appSettings.AudioFileName}.{_appSettings.OutputAudioFormat}");
            Console.WriteLine("Начинаем конвертацию...");
            AudioConverter.TryConvert(inputAudioPath, outputAudioPath);
            Console.WriteLine("Файл конвертирован");

            return "Конвертация успешно завершена";
        }
    }

    
}
