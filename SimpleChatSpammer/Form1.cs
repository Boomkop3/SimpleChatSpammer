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

        private void bnGo_Click(object sender, EventArgs e)
        {

        }
    }
}
