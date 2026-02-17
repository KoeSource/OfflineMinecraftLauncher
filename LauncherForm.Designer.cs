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
            label1 = new Label();
            cbVersion = new ComboBox();
            pbFiles = new ProgressBar();
            pbProgress = new ProgressBar();
            lbProgress = new Label();
            btnStart = new Button();
            usernameInput = new TextBox();
            label2 = new Label();
            minecraftVersion = new ComboBox();
            characterPictureBox = new PictureBox();
            label3 = new Label();
            characterHelpPictureBox = new PictureBox();
            minRAMinput = new TextBox();
            maxRAMinput = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)characterPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)characterHelpPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 71);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Select version:";
            // 
            // cbVersion
            // 
            cbVersion.FormattingEnabled = true;
            cbVersion.Location = new Point(14, 95);
            cbVersion.Margin = new Padding(3, 4, 3, 4);
            cbVersion.Name = "cbVersion";
            cbVersion.Size = new Size(167, 28);
            cbVersion.TabIndex = 1;
            cbVersion.TextChanged += cbVersion_TextChanged;
            // 
            // pbFiles
            // 
            pbFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbFiles.Location = new Point(14, 274);
            pbFiles.Margin = new Padding(3, 4, 3, 4);
            pbFiles.Name = "pbFiles";
            pbFiles.Size = new Size(434, 27);
            pbFiles.TabIndex = 3;
            // 
            // pbProgress
            // 
            pbProgress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbProgress.Location = new Point(14, 313);
            pbProgress.Margin = new Padding(3, 4, 3, 4);
            pbProgress.Name = "pbProgress";
            pbProgress.Size = new Size(434, 27);
            pbProgress.TabIndex = 4;
            // 
            // lbProgress
            // 
            lbProgress.Location = new Point(14, 208);
            lbProgress.Name = "lbProgress";
            lbProgress.Size = new Size(434, 20);
            lbProgress.TabIndex = 5;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.Location = new Point(14, 228);
            btnStart.Margin = new Padding(0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(434, 33);
            btnStart.TabIndex = 7;
            btnStart.Text = "Launch";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // usernameInput
            // 
            usernameInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernameInput.Location = new Point(14, 36);
            usernameInput.Margin = new Padding(3, 4, 3, 4);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(334, 27);
            usernameInput.TabIndex = 9;
            usernameInput.TextChanged += usernameInput_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Username:";
            // 
            // minecraftVersion
            // 
            minecraftVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            minecraftVersion.FormattingEnabled = true;
            minecraftVersion.Items.AddRange(new object[] { "Releases and Installed", "All Versions" });
            minecraftVersion.Location = new Point(189, 95);
            minecraftVersion.Margin = new Padding(3, 4, 3, 4);
            minecraftVersion.Name = "minecraftVersion";
            minecraftVersion.Size = new Size(159, 28);
            minecraftVersion.TabIndex = 10;
            minecraftVersion.Text = "Releases and Installed";
            minecraftVersion.SelectedIndexChanged += minecraftVersion_SelectedIndexChanged;
            // 
            // characterPictureBox
            // 
            characterPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            characterPictureBox.BackColor = Color.Transparent;
            characterPictureBox.Image = Properties.Resources.Steve_classic;
            characterPictureBox.Location = new Point(355, 36);
            characterPictureBox.Margin = new Padding(3, 4, 3, 4);
            characterPictureBox.Name = "characterPictureBox";
            characterPictureBox.Size = new Size(93, 153);
            characterPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            characterPictureBox.TabIndex = 11;
            characterPictureBox.TabStop = false;
            characterPictureBox.Tag = "Steve classic";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(355, 12);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 12;
            label3.Text = "Skin preview:";
            // 
            // characterHelpPictureBox
            // 
            characterHelpPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            characterHelpPictureBox.Image = Properties.Resources.icon_info;
            characterHelpPictureBox.Location = new Point(430, 36);
            characterHelpPictureBox.Margin = new Padding(3, 4, 3, 4);
            characterHelpPictureBox.Name = "characterHelpPictureBox";
            characterHelpPictureBox.Size = new Size(18, 21);
            characterHelpPictureBox.TabIndex = 13;
            characterHelpPictureBox.TabStop = false;
            characterHelpPictureBox.Tag = "The game will choose your offline skin from your username";
            // 
            // minRAMinput
            // 
            minRAMinput.Location = new Point(14, 162);
            minRAMinput.Name = "minRAMinput";
            minRAMinput.Size = new Size(167, 27);
            minRAMinput.TabIndex = 14;
            minRAMinput.KeyPress += numbersOnlyInput_KeyPress;
            // 
            // maxRAMinput
            // 
            maxRAMinput.Location = new Point(189, 162);
            maxRAMinput.Name = "maxRAMinput";
            maxRAMinput.Size = new Size(159, 27);
            maxRAMinput.TabIndex = 15;
            maxRAMinput.KeyPress += numbersOnlyInput_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 139);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 16;
            label4.Text = "minRAM (MB)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 139);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 17;
            label5.Text = "maxRAM (MB)";
            // 
            // LauncherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 353);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maxRAMinput);
            Controls.Add(minRAMinput);
            Controls.Add(characterHelpPictureBox);
            Controls.Add(label3);
            Controls.Add(characterPictureBox);
            Controls.Add(minecraftVersion);
            Controls.Add(usernameInput);
            Controls.Add(label2);
            Controls.Add(btnStart);
            Controls.Add(lbProgress);
            Controls.Add(pbProgress);
            Controls.Add(pbFiles);
            Controls.Add(cbVersion);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(706, 400);
            MinimumSize = new Size(477, 400);
            Name = "LauncherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Offline Minecraft Launcher";
            Load += LauncherForm_Load;
            ((System.ComponentModel.ISupportInitialize)characterPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)characterHelpPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbVersion;
        private ProgressBar pbFiles;
        private ProgressBar pbProgress;
        private Label lbProgress;
        private Button btnStart;
        private ComboBox minecraftVersion;
        private TextBox usernameInput;
        private Label label2;
        private PictureBox characterPictureBox;
        private Label label3;
        private PictureBox characterHelpPictureBox;
        private TextBox minRAMinput;
        private TextBox maxRAMinput;
        private Label label4;
        private Label label5;
    }
}
