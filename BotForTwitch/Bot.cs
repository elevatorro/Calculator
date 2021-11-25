using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.Client.Models;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using System.IO;

namespace BotForTwitch
{
    public class Bot
    {
        TwitchClient client = new TwitchClient();
        //введите ник бота и его токен как: ConnectionCredentials credentials = new ConnectionCredentials("bot_nicname", "token from twich");
        ConnectionCredentials credentials = new ConnectionCredentials("suda nick", "suda token");
       
        public static List<String> raffle_event = new List<String>();
        //ключевое слово(фраза) для роызгрыша. Поставил заглушку в виде случайного набора символов, чтобы кто-то просто не вписывал это, пока стример не начнет розыгрыш
        public static string _keyword = "mvkasdkvzasdom132";
        //количество победителей в розыгрыше(-1 как заглушка, потом стример сам вписывает кол-во побетилей)
        public static int _keynumber = -1;
        //список победителей
        public string winners = "";
        //победители предыдущего роызгрыша
        public string last_winners = "";
        public int state = 0;
        //ник стримера(вводится при включении бота)
        public string streamer_nick = Program.streamer_nickname;
        public Bot() {
            client.Initialize(credentials, streamer_nick);
            
            client.OnLog += Client_OnLog;
            client.OnJoinedChannel += Client_OnJoinedChannel;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnChatCommandReceived += Client_OnChatCommandReceived;

            client.Connect();
        }
        //в консоли выведется, что бот подключен к стримеру
        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            // client.SendMessage(e.Channel, "Привет! Бот успешно подключен к каналу.");
            Console.WriteLine($"Бот подключен к {streamer_nick}");
        }
        //логируется каждое сообщение в чате на всякий, это уже для меня
        private void Client_OnLog(object sender, OnLogArgs e)
        {
            Console.WriteLine(e.Data);
            string writePath = "C:\\Users\\naumo\\source\\repos\\BotForTwitch\\logs.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"{DateTime.Now}:    { e.Data}");
                }

                /*using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    
                }*/

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        //метод для комманд бота: !кубик - рандом от 1 до 6, !winners - список победителей прошлого розыгрыша, !очистить - очистить текущий список участников
        //!start_raffle - заглушка, чтобы он не писал "такой команды нет", хотя этот default можно убрать от греха подальше
        private void Client_OnChatCommandReceived(object sender, OnChatCommandReceivedArgs e) {
            switch (e.Command.CommandText.ToLower()) {
                case "кубик":
                    Random rnd = new Random();
                    var result = rnd.Next(1, 7);
                    client.SendMessage(e.Command.ChatMessage.Channel, $"Результат: {result}");
                    break;


                case "разыграть":
                    /*if ((e.Command.ChatMessage.IsModerator) | (e.Command.ChatMessage.IsBroadcaster))
                    {
                        Random rnd1 = new Random();
                        int result1 = rnd1.Next(0, raffle_event.Count - 1);
                        Console.WriteLine(result1);
                        Console.WriteLine(raffle_event[result1]);
                        client.SendMessage(e.Command.ChatMessage.Channel, $"Победитель {raffle_event[result1]}");
                        //  raffle_event.Clear();
                        Console.WriteLine($"в списке {raffle_event.Count} записей");
                        //  _keyword = "mvkasdkvzasdom132";
                    }*/
                    break;
                case "winners":
                    if ((e.Command.ChatMessage.IsModerator) | (e.Command.ChatMessage.IsBroadcaster))
                        if (last_winners != "")
                            client.SendMessage(e.Command.ChatMessage.Channel, $"Прошлые победители {last_winners}");
                        else
                            client.SendMessage(e.Command.ChatMessage.Channel, $"Победителей еще не было");
                    break;
                case "очистить":
                    if ((e.Command.ChatMessage.IsModerator) | (e.Command.ChatMessage.IsBroadcaster)) {
                        raffle_event.Clear();
                        last_winners = winners;
                        winners = "";
                        Console.WriteLine($"в списке {raffle_event.Count} записей");
                        _keyword = "mvkasdkvzasdom132";
                        state = 0;
                    }
                    break;
                case "start_raffle":
                    break;
                default:
                    client.SendMessage(e.Command.ChatMessage.Channel, "Такой команды нет");
                    break;
            }
        }
        //метод для простых сообщений чата
        //ну тут еще проходит розыгрыш, потому что !start_raffle {ключевое слово(фраза)} в команду не закинешь :D
        //сюда можно еще добавить бан за определенные слова в сообщении, но этого у меня нет, потому что не под эти цели создавался(в закомменченном блоке можно увидеть, как это делать)
        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            
            /* if (!e.ChatMessage.IsBroadcaster && !e.ChatMessage.IsModerator)
             {
                 if (e.ChatMessage.Message.ToLower().Contains("плохой человек"))
                 {
                     client.TimeoutUser(e.ChatMessage.Channel, e.ChatMessage.Username, TimeSpan.FromSeconds(30), "Нет, ты плохой человек");
                 }
             }*/
             //чтобы разыграть, вводишь !разыграть {количество(цифрой)} . Если количество больше, чем участников, бот скажет об этом. Если розыгрыша нет, тоже скажет. Если напишешь как олух, то тоже скажет))
            if ((e.ChatMessage.Message.ToLower().StartsWith("!разыграть") & (e.ChatMessage.IsBroadcaster))) {
                try
                {
                    if ((state == 1) & (raffle_event.Count>0) & (raffle_event.Count>=_keynumber))
                    {
                        string[] subs = e.ChatMessage.Message.Split(' ', 2, StringSplitOptions.None);
                        _keynumber = Int32.Parse(subs[1]);
                        for (int i = 0; i < _keynumber; i++)
                        {
                            Random rnd1 = new Random();
                            int result = rnd1.Next(0, raffle_event.Count);
                            winners = winners + raffle_event[result] + " ";
                            raffle_event.Remove(raffle_event[result]);


                        }
                        client.SendMessage(e.ChatMessage.Channel, $"winners are: {winners}");
                    }
                    if (state == 0) {
                        client.SendMessage(e.ChatMessage.Channel, "Розыгрыша нет");

                    }
                    if ((state != 0) & (raffle_event.Count==0)) {
                        client.SendMessage(e.ChatMessage.Channel, $"В розыгрыше по слову {_keyword} нет участников. Закройте его или подождите, пока будут участники");
                    }

                    if ((state == 1) & (raffle_event.Count<_keynumber)) {
                        client.SendMessage(e.ChatMessage.Channel, $"В розыгрыше участвует {raffle_event.Count} участников, что меньше количества победителей {_keynumber}. Выберете другое количество победителей,но чтобы это число было меньше {raffle_event.Count}");
                    }
                }
                catch (Exception ex) {
                    client.SendMessage(e.ChatMessage.Channel, "введи !разыграть {цифра} . Например !разыграть 2");
                }
            }
            //чтобы начать розыгрышь, в идеале сначала прописать !очистить , потом !start_raffle {слово или фразу}. Записывается ник только 1 раз, поэтому пусть пишут сколько угодно ключевую фразу
            //также нельзя создать роызгрыш, если уже идет один, и бот напомнит об этом, если попытаешься.
            if ((e.ChatMessage.Message.ToLower().StartsWith("!start_raffle")) & (e.ChatMessage.IsBroadcaster)) {
                if (state == 0) {
                    state = 1;
                    string[] subs = e.ChatMessage.Message.Split(' ', 2, StringSplitOptions.None);
                    _keyword = subs[1];
                    Console.WriteLine($"{_keyword}____ {subs[1]}");
                    client.SendMessage(e.ChatMessage.Channel, $"Начался розыгрыш. Ключевое слово '{_keyword}'");

                    if (e.ChatMessage.Message == _keyword) {
                        if (raffle_event.Count == 0)
                        {
                            raffle_event.Add(e.ChatMessage.Username);
                            Console.WriteLine($"в списке {raffle_event.Count} записей");

                        }
                        else
                        {
                            if (!raffle_event.Contains(e.ChatMessage.Username))
                            {
                                raffle_event.Add(e.ChatMessage.Username);
                                Console.WriteLine($"в списке {raffle_event.Count} записей");
                            }
                        }
                    }
                }
                else  {
                    if (state==1)
                    client.SendMessage(e.ChatMessage.Channel, $"Розыгрыш уже проходит под словом {_keyword} . Закройте этот, чтобы создать новый");
                }
            }

        }
    }
}
