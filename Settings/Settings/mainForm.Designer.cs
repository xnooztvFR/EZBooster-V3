namespace Settings
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountListBox = new System.Windows.Forms.ListBox();
            this.gameListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblNewAccount = new System.Windows.Forms.Label();
            this.accountListBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblStartBooster = new MetroSet_UI.Controls.MetroSetButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbHideToTray = new System.Windows.Forms.CheckBox();
            this.cbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFindGames = new System.Windows.Forms.Label();
            this.txtGameItem = new System.Windows.Forms.TextBox();
            this.gameList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRemoveLoginKey = new System.Windows.Forms.Label();
            this.txtLoginKey = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIgnoreAccount = new System.Windows.Forms.CheckBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cbOnlineStatus = new System.Windows.Forms.CheckBox();
            this.cbRestartGames = new System.Windows.Forms.CheckBox();
            this.cbJoinGroup = new System.Windows.Forms.CheckBox();
            this.cbCommunity = new System.Windows.Forms.CheckBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gameListMenu.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.accountListBoxMenu.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // accountListBox
            // 
            this.accountListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountListBox.ForeColor = System.Drawing.Color.Gray;
            this.accountListBox.FormattingEnabled = true;
            resources.ApplyResources(this.accountListBox, "accountListBox");
            this.accountListBox.Name = "accountListBox";
            this.accountListBox.SelectedIndexChanged += new System.EventHandler(this.accountListBox_SelectedIndexChanged);
            this.accountListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.accountListBox_MouseDown);
            // 
            // gameListMenu
            // 
            this.gameListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.gameListMenu.Name = "gameListMenu";
            this.gameListMenu.ShowImageMargin = false;
            resources.ApplyResources(this.gameListMenu, "gameListMenu");
            this.gameListMenu.Opening += new System.ComponentModel.CancelEventHandler(this.gameListMenu_Opening);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblNewAccount);
            this.groupBox4.Controls.Add(this.accountListBox);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblNewAccount
            // 
            resources.ApplyResources(this.lblNewAccount, "lblNewAccount");
            this.lblNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewAccount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNewAccount.Name = "lblNewAccount";
            this.lblNewAccount.Click += new System.EventHandler(this.lblNewAccount_Click);
            // 
            // accountListBoxMenu
            // 
            this.accountListBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeAccountToolStripMenuItem});
            this.accountListBoxMenu.Name = "accountListBoxMenu";
            this.accountListBoxMenu.ShowImageMargin = false;
            resources.ApplyResources(this.accountListBoxMenu, "accountListBoxMenu");
            this.accountListBoxMenu.Opening += new System.ComponentModel.CancelEventHandler(this.accountListBoxMenu_Opening);
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            resources.ApplyResources(this.removeAccountToolStripMenuItem, "removeAccountToolStripMenuItem");
            this.removeAccountToolStripMenuItem.Click += new System.EventHandler(this.removeAccountToolStripMenuItem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblStartBooster);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // lblStartBooster
            // 
            this.lblStartBooster.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblStartBooster.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblStartBooster.DisabledForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.lblStartBooster, "lblStartBooster");
            this.lblStartBooster.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.lblStartBooster.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.lblStartBooster.HoverTextColor = System.Drawing.Color.White;
            this.lblStartBooster.Name = "lblStartBooster";
            this.lblStartBooster.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblStartBooster.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lblStartBooster.NormalTextColor = System.Drawing.Color.White;
            this.lblStartBooster.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.lblStartBooster.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.lblStartBooster.PressTextColor = System.Drawing.Color.White;
            this.lblStartBooster.Style = MetroSet_UI.Design.Style.Light;
            this.lblStartBooster.StyleManager = null;
            this.lblStartBooster.ThemeAuthor = "Narwin";
            this.lblStartBooster.ThemeName = "MetroLite";
            this.lblStartBooster.Click += new System.EventHandler(this.lblStartBooster_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbHideToTray);
            this.groupBox5.Controls.Add(this.cbCheckForUpdates);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // cbHideToTray
            // 
            resources.ApplyResources(this.cbHideToTray, "cbHideToTray");
            this.cbHideToTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHideToTray.Name = "cbHideToTray";
            this.cbHideToTray.UseVisualStyleBackColor = true;
            // 
            // cbCheckForUpdates
            // 
            resources.ApplyResources(this.cbCheckForUpdates, "cbCheckForUpdates");
            this.cbCheckForUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCheckForUpdates.Name = "cbCheckForUpdates";
            this.cbCheckForUpdates.UseVisualStyleBackColor = true;
            this.cbCheckForUpdates.CheckedChanged += new System.EventHandler(this.cbCheckForUpdates_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFindGames);
            this.groupBox3.Controls.Add(this.txtGameItem);
            this.groupBox3.Controls.Add(this.gameList);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // lblFindGames
            // 
            resources.ApplyResources(this.lblFindGames, "lblFindGames");
            this.lblFindGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFindGames.Name = "lblFindGames";
            this.lblFindGames.Click += new System.EventHandler(this.lblFindGames_Click);
            this.lblFindGames.MouseEnter += new System.EventHandler(this.lblFindGames_MouseEnter);
            this.lblFindGames.MouseLeave += new System.EventHandler(this.lblFindGames_MouseLeave);
            // 
            // txtGameItem
            // 
            this.txtGameItem.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.txtGameItem, "txtGameItem");
            this.txtGameItem.Name = "txtGameItem";
            this.txtGameItem.TextChanged += new System.EventHandler(this.txtGameItem_TextChanged);
            this.txtGameItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGameItem_KeyDown);
            // 
            // gameList
            // 
            this.gameList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameList.ContextMenuStrip = this.gameListMenu;
            this.gameList.ForeColor = System.Drawing.Color.Gray;
            this.gameList.FormattingEnabled = true;
            resources.ApplyResources(this.gameList, "gameList");
            this.gameList.Name = "gameList";
            this.gameList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gameList_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRemoveLoginKey);
            this.groupBox2.Controls.Add(this.txtLoginKey);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUsername);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblRemoveLoginKey
            // 
            resources.ApplyResources(this.lblRemoveLoginKey, "lblRemoveLoginKey");
            this.lblRemoveLoginKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemoveLoginKey.Name = "lblRemoveLoginKey";
            this.lblRemoveLoginKey.Click += new System.EventHandler(this.lblRemoveLoginKey_Click);
            this.lblRemoveLoginKey.MouseEnter += new System.EventHandler(this.lblRemoveLoginKey_MouseEnter);
            this.lblRemoveLoginKey.MouseLeave += new System.EventHandler(this.lblRemoveLoginKey_MouseLeave);
            // 
            // txtLoginKey
            // 
            this.txtLoginKey.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.txtLoginKey, "txtLoginKey");
            this.txtLoginKey.Name = "txtLoginKey";
            this.txtLoginKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginKey_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIgnoreAccount);
            this.groupBox1.Controls.Add(this.txtResponse);
            this.groupBox1.Controls.Add(this.cbOnlineStatus);
            this.groupBox1.Controls.Add(this.cbRestartGames);
            this.groupBox1.Controls.Add(this.cbJoinGroup);
            this.groupBox1.Controls.Add(this.cbCommunity);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cbIgnoreAccount
            // 
            resources.ApplyResources(this.cbIgnoreAccount, "cbIgnoreAccount");
            this.cbIgnoreAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIgnoreAccount.Name = "cbIgnoreAccount";
            this.cbIgnoreAccount.UseVisualStyleBackColor = true;
            // 
            // txtResponse
            // 
            this.txtResponse.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.txtResponse, "txtResponse");
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // cbOnlineStatus
            // 
            resources.ApplyResources(this.cbOnlineStatus, "cbOnlineStatus");
            this.cbOnlineStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOnlineStatus.Name = "cbOnlineStatus";
            this.cbOnlineStatus.UseVisualStyleBackColor = true;
            this.cbOnlineStatus.CheckedChanged += new System.EventHandler(this.cbOnlineStatus_CheckedChanged);
            // 
            // cbRestartGames
            // 
            resources.ApplyResources(this.cbRestartGames, "cbRestartGames");
            this.cbRestartGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRestartGames.Name = "cbRestartGames";
            this.cbRestartGames.UseVisualStyleBackColor = true;
            // 
            // cbJoinGroup
            // 
            resources.ApplyResources(this.cbJoinGroup, "cbJoinGroup");
            this.cbJoinGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbJoinGroup.Name = "cbJoinGroup";
            this.cbJoinGroup.UseVisualStyleBackColor = true;
            // 
            // cbCommunity
            // 
            resources.ApplyResources(this.cbCommunity, "cbCommunity");
            this.cbCommunity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCommunity.Name = "cbCommunity";
            this.cbCommunity.UseVisualStyleBackColor = true;
            this.cbCommunity.CheckedChanged += new System.EventHandler(this.cbCommunity_CheckedChanged);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.panelSettings, "panelSettings");
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSettings_Paint);
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gameListMenu.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.accountListBoxMenu.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox accountListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblNewAccount;
        private System.Windows.Forms.ContextMenuStrip gameListMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip accountListBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbHideToTray;
        private System.Windows.Forms.CheckBox cbCheckForUpdates;
        private MetroSet_UI.Controls.MetroSetButton lblStartBooster;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFindGames;
        private System.Windows.Forms.TextBox txtGameItem;
        private System.Windows.Forms.ListBox gameList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRemoveLoginKey;
        private System.Windows.Forms.TextBox txtLoginKey;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbIgnoreAccount;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.CheckBox cbOnlineStatus;
        private System.Windows.Forms.CheckBox cbRestartGames;
        private System.Windows.Forms.CheckBox cbJoinGroup;
        private System.Windows.Forms.CheckBox cbCommunity;
        private System.Windows.Forms.Panel panelSettings;
    }
}

