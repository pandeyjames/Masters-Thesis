using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Syn.Bot.Siml;

namespace Demo.LCSK
{
    public class Agent
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsOnline { get; set; }
        //public string msg { get; set; }

        public SimlBot Chatbot;
        public string Msg { get; set; }
        //InitializeComponent();

        public void getMsg(string msg)
        {
            var result = Chatbot.Chat(msg);
            Msg = string.Format("User: {0}\nBot: {1}\n{2}", msg, result.BotMessage, result);
            msg = string.Empty;
        }


        public Agent()
        {
            Chatbot = new SimlBot();
            Chatbot.PackageManager.LoadFromString(File.ReadAllText("Knowledge.simlpk"));
        }
        public void setAgentAsBot()
        {
            Id = "AskJames";
            Name = "James";
            IsOnline = true;
        }
        public void chatWithBot()
        {


        }

    }

    //public class Bot
    //{
    //    //public MainWindow()
    //    //{
    //    //    InitializeComponent();
    //    //}
    //    public SimlBot Chatbot;
    //    public string Msg { get; set; }
    //    public Bot()
    //    {
    //        //InitializeComponent();
    //        Chatbot = new SimlBot();
    //        Chatbot.PackageManager.LoadFromString(File.ReadAllText("Knowledge.simlpk"));
    //    }
    //    public void getMsg(string msg)
    //    {
    //        var result = Chatbot.Chat(msg);
    //        Msg = string.Format("User: {0}\nBot: {1}\n{2}", msg, result.BotMessage, result);
    //        msg = string.Empty;
    //    }
    //}
}