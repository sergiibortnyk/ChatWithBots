using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotSDK;

namespace BotDog
{
    public class BotDog : IBot
    {
        private string name = "Burger";
        private string answer = null;

        private Dictionary<string, string> Phrases = new Dictionary<string, string>()
        {
            {"hi, dog", "gav"},
            {"bye, dog", "gav"},
            {"dog", "gav, gav, gav"},
            {"What is your name?", "gaaaaav"},
            {"Burger", "gggggav"},
            {"How old are you?", "gav gav gav gav"},

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
