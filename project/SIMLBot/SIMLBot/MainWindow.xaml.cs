using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Syn.Bot.Siml;

namespace SIMLBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public MainWindow()
        //{
        //    InitializeComponent();
        //}
        public SimlBot Chatbot;
        public MainWindow()
        {
            InitializeComponent();
            Chatbot = new SimlBot();
            Chatbot.PackageManager.LoadFromString(File.ReadAllText("Knowledge.simlpk"));
        }
        private void SendButton_OnClick(object sender, RoutedEventArgs e)
        {
            var result = Chatbot.Chat(InputBox.Text);
            OutputBox.Text = string.Format("User: {0}\nBot: {1}\n{2}", InputBox.Text, result.BotMessage, OutputBox.Text);
            InputBox.Text = string.Empty;
        }
    }


}
