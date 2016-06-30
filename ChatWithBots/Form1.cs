using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace ChatWithBots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        Chat conversation = new Chat();

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxMessage.Text != "")
            {
                listBoxConversation.Items.Add("Me: " + textBoxMessage.Text);
            }                
            if (conversation.BotAnswer(textBoxMessage.Text)!=null)
            {
                listBoxConversation.Items.Add(conversation.BotAnswer(textBoxMessage.Text));
            }            
            textBoxMessage.Clear();
        }
    }
}
