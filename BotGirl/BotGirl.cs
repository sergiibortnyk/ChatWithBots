using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotSDK;

namespace BotGirl
{
    public class BotGirl:IBot
    {
        private string name = "Ashley";
        private string answer = null;

        private Dictionary<string, string> Phrases = new Dictionary<string, string>()
        {
            {"hi, girl", "hi"},
            {"bye, girl", "bye"},
            {"girl", "Yes, I'm"},
            {"What is your name?", "May name is Ashley"},
            {"Ashley", "What?"},
            {"How old are you?", "I'm 20"},

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
