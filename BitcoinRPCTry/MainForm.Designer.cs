namespace BitcoinRPCTry
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnListAccount = new System.Windows.Forms.Button();
            this.btnDumpWallet = new System.Windows.Forms.Button();
            this.btnListTransactions = new System.Windows.Forms.Button();
            this.brnGetWalletInfo = new System.Windows.Forms.Button();
            this.btnBlockchainInfo = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetInfo.Location = new System.Drawing.Point(12, 12);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(83, 30);
            this.btnGetInfo.TabIndex = 0;
            this.btnGetInfo.Text = "Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // textResult
            // 
            this.textResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResult.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(12, 103);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textResult.Size = new System.Drawing.Size(584, 294);
            this.textResult.TabIndex = 1;
            this.textResult.WordWrap = false;
            // 
            // btnListAccount
            // 
            this.btnListAccount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAccount.Location = new System.Drawing.Point(260, 12);
            this.btnListAccount.Name = "btnListAccount";
            this.btnListAccount.Size = new System.Drawing.Size(107, 30);
            this.btnListAccount.TabIndex = 2;
            this.btnListAccount.Text = "List Accounts";
            this.btnListAccount.UseVisualStyleBackColor = true;
            this.btnListAccount.Click += new System.EventHandler(this.btnListAccount_Click);
            // 
            // btnDumpWallet
            // 
            this.btnDumpWallet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDumpWallet.Location = new System.Drawing.Point(428, 12);
            this.btnDumpWallet.Name = "btnDumpWallet";
            this.btnDumpWallet.Size = new System.Drawing.Size(107, 30);
            this.btnDumpWallet.TabIndex = 3;
            this.btnDumpWallet.Text = "Dump Wallet";
            this.btnDumpWallet.UseVisualStyleBackColor = true;
            this.btnDumpWallet.Click += new System.EventHandler(this.btnDumpWallet_Click);
            // 
            // btnListTransactions
            // 
            this.btnListTransactions.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListTransactions.Location = new System.Drawing.Point(260, 48);
            this.btnListTransactions.Name = "btnListTransactions";
            this.btnListTransactions.Size = new System.Drawing.Size(138, 30);
            this.btnListTransactions.TabIndex = 4;
            this.btnListTransactions.Text = "List Transactions";
            this.btnListTransactions.UseVisualStyleBackColor = true;
            this.btnListTransactions.Click += new System.EventHandler(this.btnListTransactions_Click);
            // 
            // brnGetWalletInfo
            // 
            this.brnGetWalletInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnGetWalletInfo.Location = new System.Drawing.Point(12, 48);
            this.brnGetWalletInfo.Name = "brnGetWalletInfo";
            this.brnGetWalletInfo.Size = new System.Drawing.Size(123, 30);
            this.brnGetWalletInfo.TabIndex = 5;
            this.brnGetWalletInfo.Text = "Get Wallet Info";
            this.brnGetWalletInfo.UseVisualStyleBackColor = true;
            this.brnGetWalletInfo.Click += new System.EventHandler(this.brnGetWalletInfo_Click);
            // 
            // btnBlockchainInfo
            // 
            this.btnBlockchainInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockchainInfo.Location = new System.Drawing.Point(101, 12);
            this.btnBlockchainInfo.Name = "btnBlockchainInfo";
            this.btnBlockchainInfo.Size = new System.Drawing.Size(153, 30);
            this.btnBlockchainInfo.TabIndex = 6;
            this.btnBlockchainInfo.Text = "Get Blockchain Info";
            this.btnBlockchainInfo.UseVisualStyleBackColor = true;
            this.btnBlockchainInfo.Click += new System.EventHandler(this.btnBlockchainInfo_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(548, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(48, 30);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "[o]";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 409);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(296, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://en.bitcoin.it/wiki/Original_Bitcoin_client/API_calls_list";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 434);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnBlockchainInfo);
            this.Controls.Add(this.brnGetWalletInfo);
            this.Controls.Add(this.btnListTransactions);
            this.Controls.Add(this.btnDumpWallet);
            this.Controls.Add(this.btnListAccount);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btnGetInfo);
            this.Name = "MainForm";
            this.Text = "Bitcoin RPC demo";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button btnListAccount;
        private System.Windows.Forms.Button btnDumpWallet;
        private System.Windows.Forms.Button btnListTransactions;
        private System.Windows.Forms.Button brnGetWalletInfo;
        private System.Windows.Forms.Button btnBlockchainInfo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

