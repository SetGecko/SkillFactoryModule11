using Telegram.Bot;
using Telegram.Bot.Types;

namespace VoiceTexterBot.Controllers
{
    public class InLineKeyBoardController
    {
        private readonly ITelegramBotClient _telegramClient;

        public InLineKeyBoardController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(CallbackQuery? callbackQuery, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
            await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"Обнаружено нажатие на кнопку {callbackQuery.Data}", cancellationToken: ct);
        }
    }
}