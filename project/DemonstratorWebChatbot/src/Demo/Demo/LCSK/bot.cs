//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
using System.IO;
using Syn.Bot.Siml;
using System.Web;

namespace Demo.LCSK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Bot
    {
        //public MainWindow()
        //{
        //    InitializeComponent();
        //}
        public SimlBot Chatbot;
        public string Msg { get; set; }
        public Bot()
        {
            //InitializeComponent();
            Chatbot = new SimlBot();
            Chatbot.PackageManager.LoadFromString(File.ReadAllText("Knowledge.simlpk"));
        }
        public void getMsg(string msg)
        {
            var result = Chatbot.Chat(msg);
            Msg = string.Format("User: {0}\nBot: {1}\n{2}", msg, result.BotMessage, result);
            msg = string.Empty;
        }
    }


}
