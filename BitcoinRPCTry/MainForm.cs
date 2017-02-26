using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinRPCTry
{
    public partial class MainForm : Form
    {
        private BitcoinRPC rpcClient = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private BitcoinRPC getRPCClient()
        {
            if (rpcClient == null)
                showSettingsForm();

            if (rpcClient == null)
                throw new Exception("Settings not set");
            else
                return rpcClient;
        }

        private void clearResult()
        {
            textResult.Text = "";
        }

        private void showResult(string unformated)
        {
            textResult.Text = JValue.Parse(unformated).ToString(Formatting.Indented);
        }

        private void Call(Func<string> call)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                clearResult();
                string str = call();
                showResult(str);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            Call(delegate () { return getRPCClient().getInfo(); });
        }

        private void btnListAccount_Click(object sender, EventArgs e)
        {
            Call(delegate() { return getRPCClient().listAccounts(); });
        }

        private void btnDumpWallet_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\BitcoinData\wallet_dump.txt";

            clearResult();
            getRPCClient().dumpWallet(fileName);
            string str = System.IO.File.ReadAllText(fileName);
            textResult.Text = str;
        }

        private void btnListTransactions_Click(object sender, EventArgs e)
        {
            Call(delegate () { return getRPCClient().listTransactions(); });
        }

        private void brnGetWalletInfo_Click(object sender, EventArgs e)
        {
            Call(delegate () { return getRPCClient().getWalletInfo(); });
        }

        private void btnBlockchainInfo_Click(object sender, EventArgs e)
        {
            Call(delegate () { return getRPCClient().getBlockchainInfo(); });
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //if (showSettingsForm() == false)
            //{
            //    Close();
            //}
        }

        private bool showSettingsForm()
        {
            var form = new SettingsForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                rpcClient = new BitcoinRPC() { Host = form.Host, Port = form.Port, User = form.User, Password = form.Password };
                Text = string.Format("Bitcoin RPC demo [{0}:{1}]", form.Host, form.Port);

                return true;
            }
            else
                return false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSettingsForm();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }
    }
}
