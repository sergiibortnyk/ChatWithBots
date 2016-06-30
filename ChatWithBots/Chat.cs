using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ChatWithBots
{
    class Chat
    {
        private List<Assembly> allAssemblies = new List<Assembly>();
        private string path = Path.Combine(Environment.CurrentDirectory, @"Bots\");
        private string botName = null;
        private string answer = null;

        public string BotAnswer (string message)
        {
            object[] parametersArray = new object[] { message };
            answer = null;
            botName = null;
            foreach (string dll in Directory.GetFiles(path, "*.dll"))
            {
                allAssemblies.Add(Assembly.LoadFile(dll));
            }
            foreach (Assembly myAsm in allAssemblies)
            {
                foreach (Type type in myAsm.GetTypes())
                {
                    object obj = Activator.CreateInstance(type);

                    foreach (MethodInfo method in type.GetMethods())
                    {
                        if (method.Name.Equals("get_Name", StringComparison.InvariantCultureIgnoreCase))
                        {
                            botName = Convert.ToString(method.Invoke(obj, null));
                        }
                        if ((method.Name.Equals("Answer", StringComparison.InvariantCultureIgnoreCase)) && ((method.Invoke(obj, parametersArray)) != null))
                        {
                            answer= (botName + ": " + Convert.ToString(method.Invoke(obj, parametersArray)));
                        }
                    }
                }
            }
            return answer;
        }         
    }
}
