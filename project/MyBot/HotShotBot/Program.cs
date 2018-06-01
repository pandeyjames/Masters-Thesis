using System;
using AIMLbot;
using System.Speech.Synthesis;

namespace MyBot
{

    public class MyBot
    {

        const string UserId = "consoleUser";
        private Bot AimlBot;
        private User myUser;
        public string message;
  
        public MyBot()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            //----------------------------------------------------------------------------------------

            AimlBot = new Bot();
            myUser = new User(UserId, AimlBot);
            Initialize();
        }

        // Loads all the AIML files in the \AIML folder         
        public void Initialize()
        {
            AimlBot.loadSettings();
            AimlBot.isAcceptingUserInput = false;
            AimlBot.loadAIMLFromFiles();
            AimlBot.isAcceptingUserInput = true;
        }

        // Given an input string, finds a response using AIMLbot lib
        public String getOutput(String input)
        {
            Request r = new Request(input, myUser, AimlBot);
            Result res = AimlBot.Chat(r);
            return (res.Output);
        }
    }
    class Program
    {
        static MyBot bot;
        static void Main(string[] args)
        {
            string input="start";
            while (input!="exit" )
            {
            
                bot = new MyBot();
                Console.Write("You: ");
               // message=
                input = Console.ReadLine();
                var output = bot.getOutput(input);

                Console.WriteLine(input);
                Console.WriteLine("Bot: " + output);
                bot.message = "Bot: " + output;
            
                //Make the bot Speak
                  //SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                //synthesizer.Volume = 100;  // 0...100
                //synthesizer.Rate = -2;     // -10...10

                // Synchronous
                //synthesizer.Speak(output);

                // Asynchronous
                // synthesizer.SpeakAsync(output);

            }
         }
    }
}
