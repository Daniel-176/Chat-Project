namespace chat
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusLabel = new Label();
            playerlist = new ListBox();
            chatbox = new TextBox();
            chatlist = new ListBox();
            username = new TextBox();
            connectingscreen = new Panel();
            clab = new Label();
            connectingscreen.SuspendLayout();
            SuspendLayout();
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(644, 9);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 15);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Status";
            // 
            // playerlist
            // 
            playerlist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            playerlist.BackColor = Color.Gray;
            playerlist.BorderStyle = BorderStyle.None;
            playerlist.ForeColor = Color.White;
            playerlist.FormattingEnabled = true;
            playerlist.ItemHeight = 15;
            playerlist.Location = new Point(644, 27);
            playerlist.Name = "playerlist";
            playerlist.Size = new Size(144, 390);
            playerlist.TabIndex = 2;
            // 
            // chatbox
            // 
            chatbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatbox.BackColor = Color.Silver;
            chatbox.BorderStyle = BorderStyle.None;
            chatbox.ForeColor = Color.Black;
            chatbox.Location = new Point(12, 422);
            chatbox.Name = "chatbox";
            chatbox.PlaceholderText = "chat";
            chatbox.Size = new Size(626, 16);
            chatbox.TabIndex = 3;
            chatbox.KeyDown += KEYDOWNN;
            // 
            // chatlist
            // 
            chatlist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatlist.BackColor = Color.Gray;
            chatlist.BorderStyle = BorderStyle.None;
            chatlist.Font = new Font("Source Sans Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chatlist.ForeColor = Color.White;
            chatlist.FormattingEnabled = true;
            chatlist.ItemHeight = 15;
            chatlist.Location = new Point(12, 12);
            chatlist.Name = "chatlist";
            chatlist.Size = new Size(626, 405);
            chatlist.TabIndex = 4;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username.BackColor = Color.Silver;
            username.BorderStyle = BorderStyle.None;
            username.ForeColor = Color.Black;
            username.Location = new Point(644, 422);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(144, 16);
            username.TabIndex = 5;
            username.TextChanged += username_TextChanged;
            // 
            // connectingscreen
            // 
            connectingscreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            connectingscreen.BackColor = Color.FromArgb(64, 64, 64);
            connectingscreen.Controls.Add(clab);
            connectingscreen.Location = new Point(0, 0);
            connectingscreen.Name = "connectingscreen";
            connectingscreen.Size = new Size(0, 0);
            connectingscreen.TabIndex = 6;
            // 
            // clab
            // 
            clab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clab.AutoSize = true;
            clab.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            clab.ForeColor = SystemColors.ActiveCaption;
            clab.Location = new Point(12, 9);
            clab.Name = "clab";
            clab.Size = new Size(275, 32);
            clab.TabIndex = 0;
            clab.Text = "Connecting to the chat...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(connectingscreen);
            Controls.Add(username);
            Controls.Add(chatlist);
            Controls.Add(chatbox);
            Controls.Add(playerlist);
            Controls.Add(statusLabel);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            connectingscreen.ResumeLayout(false);
            connectingscreen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statusLabel;
        private ListBox playerlist;
        private TextBox chatbox;
        private ListBox chatlist;
        private TextBox username;
        private Panel connectingscreen;
        private Label clab;
    }
}