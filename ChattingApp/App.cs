using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace ChattingApp
{
    public partial class App : Form
    {
        WhatsApp whatsApp;
        public App()
        {
            InitializeComponent();
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {

        }

        private void checkRemember_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = checkRemember.Checked;
            Properties.Settings.Default.PhoneNumber = textPhoneNumber.Text;
            Properties.Settings.Default.Password = textPassword.Text;
            Properties.Settings.Default.Save();
        }
        private void App_Load(object sender, EventArgs e)
        {
            signOutToolStripMenuItem.Visible = false;
            panel1.BringToFront();
            if (Properties.Settings.Default.Remember)
            {
                textPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
                textPassword.Text = Properties.Settings.Default.Password;
                checkRemember.Checked = Properties.Settings.Default.Remember;
            }
        }
        private void linkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(Registration register = new Registration())
            {
                if(register.ShowDialog() == DialogResult.OK)
                {
                    textPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
                    textPassword.Text = Properties.Settings.Default.Password;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
