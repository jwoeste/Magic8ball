using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Magic8ball
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }



        public string GetResponse()
        {
            Random random = new Random();

            string[] answers = new string[]
            {
                   "It is certain",
                   "It is decidedly so",
                   "Without a doubt",
                   "Yes - definitely",
                   "You may rely on it",
                   "As I see it, yes",
                   "Most likely",
                   "Outlook good",
                   "Yes", "Signs point to yes",
                   "Don't count on it",
                   "My reply is no",
                   "My sources say no",
                   "Outlook not so good",
                   "Very doubtful",
                   "Reply hazy, try again",
                   "Ask again later",
                   "Better not tell you now",
                   "Cannot predict now",
                   "Concentrate and ask again",
                   "Yes, you will if you use the force!",
                   "That is impossible!",
                   "No way!",
                   "How dare you!?",
                   "Not when the candy talks!",
                   "Never!",
                   "Stop giving me questions!"
            };

            return answers[random.Next(0, answers.Length)];

        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (question.Text != null && question.Text.Length > 0)
                labelAnswer.Text = GetResponse();
            else
                labelAnswer.Text = "Enter question please...";

        }
    }
}
