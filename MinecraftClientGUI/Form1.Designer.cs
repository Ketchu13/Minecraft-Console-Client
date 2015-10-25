namespace MinecraftClientGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.box_ip = new System.Windows.Forms.TextBox();
            this.box_password = new System.Windows.Forms.TextBox();
            this.box_Login = new System.Windows.Forms.TextBox();
            this.box_output = new System.Windows.Forms.RichTextBox();
            this.box_input = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutputLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_Login.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Login.Controls.Add(this.button1);
            this.groupBox_Login.Controls.Add(this.label3);
            this.groupBox_Login.Controls.Add(this.label2);
            this.groupBox_Login.Controls.Add(this.label1);
            this.groupBox_Login.Controls.Add(this.btn_connect);
            this.groupBox_Login.Controls.Add(this.box_ip);
            this.groupBox_Login.Controls.Add(this.box_password);
            this.groupBox_Login.Controls.Add(this.box_Login);
            this.groupBox_Login.Location = new System.Drawing.Point(12, 32);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(661, 46);
            this.groupBox_Login.TabIndex = 0;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "Connexion";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(488, 13);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(87, 23);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.BtnConnectClick);
            // 
            // box_ip
            // 
            this.box_ip.Location = new System.Drawing.Point(382, 15);
            this.box_ip.Name = "box_ip";
            this.box_ip.Size = new System.Drawing.Size(100, 20);
            this.box_ip.TabIndex = 5;
            this.box_ip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginBoxKeyUp);
            // 
            // box_password
            // 
            this.box_password.Location = new System.Drawing.Point(216, 15);
            this.box_password.Name = "box_password";
            this.box_password.PasswordChar = '•';
            this.box_password.Size = new System.Drawing.Size(100, 20);
            this.box_password.TabIndex = 3;
            this.box_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginBoxKeyUp);
            // 
            // box_Login
            // 
            this.box_Login.Location = new System.Drawing.Point(48, 15);
            this.box_Login.Name = "box_Login";
            this.box_Login.Size = new System.Drawing.Size(100, 20);
            this.box_Login.TabIndex = 1;
            this.box_Login.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginBoxKeyUp);
            // 
            // box_output
            // 
            this.box_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_output.BackColor = System.Drawing.Color.Black;
            this.box_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.box_output.Location = new System.Drawing.Point(12, 84);
            this.box_output.Name = "box_output";
            this.box_output.ReadOnly = true;
            this.box_output.Size = new System.Drawing.Size(482, 406);
            this.box_output.TabIndex = 1;
            this.box_output.Text = "";
            this.box_output.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
            // 
            // box_input
            // 
            this.box_input.AcceptsTab = true;
            this.box_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_input.Location = new System.Drawing.Point(13, 496);
            this.box_input.MaxLength = 100;
            this.box_input.Multiline = true;
            this.box_input.Name = "box_input";
            this.box_input.Size = new System.Drawing.Size(407, 20);
            this.box_input.TabIndex = 2;
            this.box_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBoxKeyDown);
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.Location = new System.Drawing.Point(426, 496);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(40, 22);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.BtnSendClick);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_about.Location = new System.Drawing.Point(472, 496);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(22, 22);
            this.btn_about.TabIndex = 4;
            this.btn_about.Text = "?";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.BtnAboutClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveOutputLogToolStripMenuItem,
            this.clearOutputLogToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveOutputLogToolStripMenuItem
            // 
            this.saveOutputLogToolStripMenuItem.Name = "saveOutputLogToolStripMenuItem";
            this.saveOutputLogToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveOutputLogToolStripMenuItem.Text = "&Save output log..";
            // 
            // clearOutputLogToolStripMenuItem
            // 
            this.clearOutputLogToolStripMenuItem.Name = "clearOutputLogToolStripMenuItem";
            this.clearOutputLogToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearOutputLogToolStripMenuItem.Text = "&Clear output log..";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server IP:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(685, 528);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.box_input);
            this.Controls.Add(this.box_output);
            this.Controls.Add(this.groupBox_Login);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Console Client GUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox box_ip;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.TextBox box_Login;
        private System.Windows.Forms.RichTextBox box_output;
        private System.Windows.Forms.TextBox box_input;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOutputLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

