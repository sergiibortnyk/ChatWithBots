using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotSDK;

namespace BotBoy
{
    public class BotBoy : IBot

    {
        string name = "Jack";

        public string Name
        {
            get
            {
                return name;
            }
        }

        private Dictionary<string, string> Phrases = new Dictionary<string, string>()
        {
            {"hi, man", "hi"},
            {"bye, man", "bye"},
            {"boy", "Yes, I'm"},
        };

        public string Answer(string message)
        {
            string answer;
            if (Phrases.TryGetValue(message, out answer))
            {
                return answer;
            }
            return null;
        }
    }
}