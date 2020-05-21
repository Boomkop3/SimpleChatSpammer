using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChatSpammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picLogo.Image = Properties.Resources.VBird_mid_square;
        }

        private int startDelay
        {
            get
            {
                return (int)numStart.Value;
            }
        }

        private int lineDelay
        {
            get
            {
                return (int)numLine.Value;
            }
        }

        private int letterDelay
        {
            get
            {
                return (int)numLetter.Value;
            }
        }

        private bool removeLines
        {
            get
            {
                return checkRemoveLines.Checked;
            }
        }

        private Queue<String> lines;

        private void init()
        {
            lines = new Queue<string>();
            var linesArray = tbxInput.Text.Replace("\r\n", "\n").Split('\n');
            foreach (string line in linesArray)
            {
                lines.Enqueue(
                    line
                );
            }
        }

        private string currentText
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                string[] linesArray = lines.ToArray();
                foreach (string line in linesArray)
                {
                    builder.AppendLine(line);
                }
                return builder.ToString();
            }
        }

        private string popLine()
        {
            if (removeLines)
            {
                tbxInput.Text = currentText;
            }
            return lines.Dequeue();
        }

        private int remainingLines
        {
            get
            {
                return lines.Count();
            }
        }

        private async void bnGo_Click(object sender, EventArgs e)
        {
            init();
            await Task.Delay(startDelay);
            while (remainingLines > 0)
            {
                string line = popLine();
                foreach (char letter in line)
                {
                    SendKeys.SendWait(letter.ToString());
                    await Task.Delay(letterDelay);
                }
                await Task.Delay(lineDelay);
            }
        }
    }
}
