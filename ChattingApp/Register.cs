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
    public partial class Registration : Form
    {
        string password;
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPhoneNumber.Text))
            {
                MessageBox.Show("Please enter your phone number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPhoneNumber.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textFullName.Text))
            {
                MessageBox.Show("Please enter your full name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textFullName.Focus();
                return;
            }
            if (WhatsAppApi.Register.WhatsRegisterV2.RequestCode(textPhoneNumber.Text, out password, "sms"))
            {
                if (string.IsNullOrEmpty(password))
                    save();
                else
                {
                    RequestCode.Enabled = false;
                    ConfirmCode.Enabled = true;
                }
            }
            else
                MessageBox.Show("Could not generate password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void save()
        {
            this.RequestCode.Enabled = false;
            this.ConfirmCode.Enabled = false;
            Properties.Settings.Default.PhoneNumber = textPhoneNumber.Text;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.FullName = textFullName.Text;
            Properties.Settings.Default.Save();
            if(Globals.DataBase.Accounts.FindByAccountID(textPhoneNumber.Text) == null)
            {
                AppData.AccountsRow row = Globals.DataBase.Accounts.NewAccountsRow();
                row.AccountID = textPhoneNumber.Text;
                row.FullName = textFullName.Text;
                row.Password = password;
                Globals.DataBase.Accounts.AddAccountsRow(row);
                Globals.DataBase.Accounts.AcceptChanges();
                Globals.DataBase.Accounts.WriteXml(string.Format("{0}\\accounts.dat", Application.StartupPath));
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(smsCode.Text))
            {
                MessageBox.Show("Please enter your sms code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                smsCode.Focus();
                return;
            }
            password = WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(textPhoneNumber.Text, smsCode.Text);
            save();
        }
    }
}
