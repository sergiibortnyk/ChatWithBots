using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotSDK;

namespace BotJack
{
    public class BotJack : IBot

    {
        private string name = "Jack";
        private string answer = null;

        private Dictionary<string, string> Phrases = new Dictionary<string, string>()
        {
            {"hi, man", "hi"},
            {"bye, man", "bye"},
            {"boy", "Yes, I'm"},
            {"What is your name?", "May name is Jack"},
            {"Jack", "What?"},
            {"How old are you?", "I'm 30"},

        };

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Answer(string message)
        {
            if (Phrases.TryGetValue(message, out answer))
            {
                return answer;
            }
            return null;
        }
    }
}
