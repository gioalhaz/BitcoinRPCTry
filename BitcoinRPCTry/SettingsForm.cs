using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinRPCTry
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public string Host { get; set; }
        public uint Port { get; set; }

        public string User { get; set; }
        public string Password { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Host = textHost.Text;
            Port = (uint)upDownPort.Value;
            User = textUser.Text;
            Password = textPassword.Text;

            Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textHost.Text = (string.IsNullOrEmpty(Host) == false) ? Host : "localhost";

            upDownPort.Value = (Port != 0) ? Port : 8332;

            if (string.IsNullOrEmpty(User) == false)
                textUser.Text = User;
        }
    }
}
