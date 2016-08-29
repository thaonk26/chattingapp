using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattingApp
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {

        }

        private void checkRemember_CheckedChanged(object sender, EventArgs e)
        {
            signOutToolStripMenuItem.Visible = false;
            if (Properties.Settings.Default.Remember)
            {
                textPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
                textPassword.Text = Properties.Settings.Default.Password;
                checkRemember.Checked = Properties.Settings.Default.Remember;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
