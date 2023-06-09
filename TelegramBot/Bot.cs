﻿//using System;
//using System.Threading.Tasks;

//namespace TelegramBot
//{
//    class Bot
//    {

//        /// <summary>
//        /// объект, отвечающий за отправку сообщений клиенту
//        /// </summary>
//        private IBotClient _telegramClient;

//        public Bot(IBotClient telegramClient)
//        {
//            _telegramClient = telegramClient;
//        }

//        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
//        {
//            _telegramClient.OnMessage += HandleMessage;
//            _telegramClient.OnMessage += HandleButtonClick;

//            Console.WriteLine("Bot started");
//        }

//        /// Обработчик входящих текстовых сообщений  
//        /// </summary>
//        private async Task HandleMessage(object sender, MessageEventArgs e)
//        {
//            // Бот получил входящее сообщение пользователя
//            var messageText = e.Message.Text;

//            // Бот Отправляет ответ
//            _telegramClient.SendTextMessage(e.ChatId, "Ответ на сообщение пользователя")
//        }

//        /// <summary>
//        /// Обработчик нажатий на кнопки
//        /// </summary>
//        private async Task HandleButtonClick(object sender, MessageEventArgs e)
//        {

//        }
//    }
//}