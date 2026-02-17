namespace OfflineMinecraftLauncher
{
    partial class LauncherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cbCloseOnLaunch = new CheckBox();
            label6 = new Label();
            jvmExtraArgsInput = new TextBox();
            label5 = new Label();
            label4 = new Label();
            maxRAMinput = new TextBox();
            minRAMinput = new TextBox();
            characterHelpPictureBox = new PictureBox();
            label3 = new Label();
            characterPictureBox = new PictureBox();
            minecraftVersion = new ComboBox();
            usernameInput = new TextBox();
            label2 = new Label();
            btnStart = new Button();
            lbProgress = new Label();
            pbProgress = new ProgressBar();
            pbFiles = new ProgressBar();
            cbVersion = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            logTextBox = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)characterHelpPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)characterPictureBox).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(482, 393);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbCloseOnLaunch);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(jvmExtraArgsInput);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(maxRAMinput);
            tabPage1.Controls.Add(minRAMinput);
            tabPage1.Controls.Add(characterHelpPictureBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(characterPictureBox);
            tabPage1.Controls.Add(minecraftVersion);
            tabPage1.Controls.Add(usernameInput);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnStart);
            tabPage1.Controls.Add(lbProgress);
            tabPage1.Controls.Add(pbProgress);
            tabPage1.Controls.Add(pbFiles);
            tabPage1.Controls.Add(cbVersion);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(474, 360);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Game";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbCloseOnLaunch
            // 
            cbCloseOnLaunch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCloseOnLaunch.AutoSize = true;
            cbCloseOnLaunch.Location = new Point(314, 252);
            cbCloseOnLaunch.Name = "cbCloseOnLaunch";
            cbCloseOnLaunch.Size = new Size(152, 24);
            cbCloseOnLaunch.TabIndex = 36;
            cbCloseOnLaunch.Text = "Close after Launch";
            cbCloseOnLaunch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 167);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 35;
            label6.Text = "JvmExtraArgs (-arg1,-arg2)";
            // 
            // jvmExtraArgsInput
            // 
            jvmExtraArgsInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            jvmExtraArgsInput.Location = new Point(6, 190);
            jvmExtraArgsInput.Name = "jvmExtraArgsInput";
            jvmExtraArgsInput.Size = new Size(460, 27);
            jvmExtraArgsInput.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 114);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 33;
            label5.Text = "maxRAM (MB)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 114);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 32;
            label4.Text = "minRAM (MB)";
            // 
            // maxRAMinput
            // 
            maxRAMinput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maxRAMinput.Location = new Point(181, 137);
            maxRAMinput.Name = "maxRAMinput";
            maxRAMinput.Size = new Size(185, 27);
            maxRAMinput.TabIndex = 31;
            maxRAMinput.TextChanged += setTextBoxToZero_TextChanged;
            maxRAMinput.KeyPress += numbersOnlyInput_KeyPress;
            // 
            // minRAMinput
            // 
            minRAMinput.Location = new Point(6, 137);
            minRAMinput.Name = "minRAMinput";
            minRAMinput.Size = new Size(163, 27);
            minRAMinput.TabIndex = 30;
            minRAMinput.TextChanged += setTextBoxToZero_TextChanged;
            minRAMinput.KeyPress += numbersOnlyInput_KeyPress;
            // 
            // characterHelpPictureBox
            // 
            characterHelpPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            characterHelpPictureBox.Image = Properties.Resources.icon_info;
            characterHelpPictureBox.Location = new Point(447, 28);
            characterHelpPictureBox.Margin = new Padding(3, 4, 3, 4);
            characterHelpPictureBox.Name = "characterHelpPictureBox";
            characterHelpPictureBox.Size = new Size(19, 21);
            characterHelpPictureBox.TabIndex = 29;
            characterHelpPictureBox.TabStop = false;
            characterHelpPictureBox.Tag = "The game will choose your offline skin from your username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(371, 4);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 28;
            label3.Text = "Skin preview:";
            // 
            // characterPictureBox
            // 
            characterPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            characterPictureBox.BackColor = Color.Transparent;
            characterPictureBox.Image = Properties.Resources.Steve_classic;
            characterPictureBox.Location = new Point(372, 28);
            characterPictureBox.Margin = new Padding(3, 4, 3, 4);
            characterPictureBox.Name = "characterPictureBox";
            characterPictureBox.Size = new Size(94, 153);
            characterPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            characterPictureBox.TabIndex = 27;
            characterPictureBox.TabStop = false;
            characterPictureBox.Tag = "Steve classic";
            // 
            // minecraftVersion
            // 
            minecraftVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            minecraftVersion.FormattingEnabled = true;
            minecraftVersion.Items.AddRange(new object[] { "Releases and Installed", "All Versions" });
            minecraftVersion.Location = new Point(181, 82);
            minecraftVersion.Margin = new Padding(3, 4, 3, 4);
            minecraftVersion.Name = "minecraftVersion";
            minecraftVersion.Size = new Size(185, 28);
            minecraftVersion.TabIndex = 26;
            minecraftVersion.Text = "Releases and Installed";
            minecraftVersion.SelectedIndexChanged += minecraftVersion_SelectedIndexChanged;
            // 
            // usernameInput
            // 
            usernameInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernameInput.Location = new Point(6, 27);
            usernameInput.Margin = new Padding(3, 4, 3, 4);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(360, 27);
            usernameInput.TabIndex = 25;
            usernameInput.TextChanged += usernameInput_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 24;
            label2.Text = "Username:";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.Location = new Point(5, 247);
            btnStart.Margin = new Padding(0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(306, 33);
            btnStart.TabIndex = 23;
            btnStart.Text = "Launch";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbProgress
            // 
            lbProgress.Location = new Point(6, 221);
            lbProgress.Name = "lbProgress";
            lbProgress.Size = new Size(460, 26);
            lbProgress.TabIndex = 22;
            // 
            // pbProgress
            // 
            pbProgress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbProgress.Location = new Point(3, 319);
            pbProgress.Margin = new Padding(3, 4, 3, 4);
            pbProgress.Name = "pbProgress";
            pbProgress.Size = new Size(467, 27);
            pbProgress.TabIndex = 21;
            // 
            // pbFiles
            // 
            pbFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbFiles.Location = new Point(3, 284);
            pbFiles.Margin = new Padding(3, 4, 3, 4);
            pbFiles.Name = "pbFiles";
            pbFiles.Size = new Size(467, 27);
            pbFiles.TabIndex = 20;
            // 
            // cbVersion
            // 
            cbVersion.FormattingEnabled = true;
            cbVersion.Location = new Point(6, 82);
            cbVersion.Margin = new Padding(3, 4, 3, 4);
            cbVersion.Name = "cbVersion";
            cbVersion.Size = new Size(163, 28);
            cbVersion.TabIndex = 19;
            cbVersion.TextChanged += cbVersion_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 58);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 18;
            label1.Text = "Select version:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(logTextBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(474, 360);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Log";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            logTextBox.Dock = DockStyle.Fill;
            logTextBox.Location = new Point(3, 3);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Both;
            logTextBox.Size = new Size(468, 354);
            logTextBox.TabIndex = 0;
            // 
            // LauncherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 393);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1400, 1000);
            MinimumSize = new Size(500, 440);
            Name = "LauncherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Offline Minecraft Launcher";
            FormClosing += LauncherForm_FormClosing;
            Load += LauncherForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)characterHelpPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)characterPictureBox).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private TextBox maxRAMinput;
        private TextBox minRAMinput;
        private PictureBox characterHelpPictureBox;
        private Label label3;
        private PictureBox characterPictureBox;
        private ComboBox minecraftVersion;
        private TextBox usernameInput;
        private Label label2;
        private Button btnStart;
        private Label lbProgress;
        private ProgressBar pbProgress;
        private ProgressBar pbFiles;
        private ComboBox cbVersion;
        private Label label1;
        private TextBox jvmExtraArgsInput;
        private Label label6;
        private TextBox logTextBox;
        private CheckBox cbCloseOnLaunch;
    }
}
