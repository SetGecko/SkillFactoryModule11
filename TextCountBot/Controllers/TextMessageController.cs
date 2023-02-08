using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using VoiceTexterBot.Models;
using System.Linq;

namespace VoiceTexterBot.Controllers
{
    public class TextMessageController 
    {
        private readonly ITelegramBotClient _telegramClient;
        
        public TextMessageController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            if (message.Text == "/start")
            {
                // Объект, представляющий кноки
                var buttons = new List<InlineKeyboardButton[]>();
                buttons.Add(new[]
                {
                        InlineKeyboardButton.WithCallbackData($" Подсчет символов" , $"stringlen"),
                        InlineKeyboardButton.WithCallbackData($" Сложение" , $"addition")
                    });

                // передаем кнопки вместе с сообщением (параметр ReplyMarkup)
                await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"<b> Наш бот умеет считать длину строки \nи складывать числа.</b> {Environment.NewLine}",
                    cancellationToken: ct, parseMode: ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttons));
            }
            else if (message.Text != "/start" && InlineKeyboardController.OperationText == "Подсчет символов") 
            {
                await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Длина сообщения: {message.Text.Length} знаков", cancellationToken: ct);
            }
            else if (message.Text != "/start" && InlineKeyboardController.OperationText == "Сложение цифр")
            {
                string[] stringArr = message.Text.Split(" ");
                int sum = 0;
                try
                {
                    foreach (var item in stringArr)
                    {
                        sum += Convert.ToInt32(item);
                    }
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Сумма чисел: {sum}", cancellationToken: ct);
                }
                catch (Exception ex)
                {
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Ошибка сложения: {ex.Message}", cancellationToken: ct);
                }
            }
            else 
            {
                await _telegramClient.SendTextMessageAsync(message.Chat.Id, "Выберите желаемую операцию через меню /start", cancellationToken: ct);
            }
        }
    }
}