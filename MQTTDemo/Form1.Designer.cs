namespace MQTTDemo
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPubTopic = new System.Windows.Forms.TextBox();
            this.txtPublish = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.txtSubTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblConnectStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.rtbSubscribe = new System.Windows.Forms.RichTextBox();
            this.cbContinuous = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiBgColor = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(432, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 43);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Publish topic";
            // 
            // txtPubTopic
            // 
            this.txtPubTopic.Location = new System.Drawing.Point(125, 72);
            this.txtPubTopic.Name = "txtPubTopic";
            this.txtPubTopic.Size = new System.Drawing.Size(193, 26);
            this.txtPubTopic.TabIndex = 2;
            this.txtPubTopic.Text = "test";
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(12, 123);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.Size = new System.Drawing.Size(568, 26);
            this.txtPublish.TabIndex = 3;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(588, 72);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(117, 82);
            this.btnPublish.TabIndex = 4;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(361, 226);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(117, 55);
            this.btnSubscribe.TabIndex = 8;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.Location = new System.Drawing.Point(123, 239);
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.Size = new System.Drawing.Size(230, 26);
            this.txtSubTopic.TabIndex = 6;
            this.txtSubTopic.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subscribe topic";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(577, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(117, 43);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.BackColor = System.Drawing.Color.LightGray;
            this.lblConnectStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConnectStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblConnectStatus.Location = new System.Drawing.Point(0, 595);
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(806, 28);
            this.lblConnectStatus.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(93, 18);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(308, 26);
            this.txtServer.TabIndex = 12;
            this.txtServer.Text = "localhost";
            // 
            // rtbSubscribe
            // 
            this.rtbSubscribe.Location = new System.Drawing.Point(12, 303);
            this.rtbSubscribe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbSubscribe.Name = "rtbSubscribe";
            this.rtbSubscribe.Size = new System.Drawing.Size(781, 254);
            this.rtbSubscribe.TabIndex = 13;
            this.rtbSubscribe.Text = "";
            // 
            // cbContinuous
            // 
            this.cbContinuous.AutoSize = true;
            this.cbContinuous.Location = new System.Drawing.Point(12, 176);
            this.cbContinuous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbContinuous.Name = "cbContinuous";
            this.cbContinuous.Size = new System.Drawing.Size(116, 24);
            this.cbContinuous.TabIndex = 14;
            this.cbContinuous.Text = "Continuous";
            this.cbContinuous.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(361, 159);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 55);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Interval (sec)";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(246, 172);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(108, 26);
            this.txtInterval.TabIndex = 17;
            this.txtInterval.Text = "1";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(387, 75);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(193, 26);
            this.txtUser.TabIndex = 19;
            this.txtUser.Text = "test";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 33);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miSettings
            // 
            this.miSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiBgColor});
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(88, 29);
            this.miSettings.Text = "Settings";
            // 
            // tsiBgColor
            // 
            this.tsiBgColor.Name = "tsiBgColor";
            this.tsiBgColor.Size = new System.Drawing.Size(236, 30);
            this.tsiBgColor.Text = "Background color";
            this.tsiBgColor.Click += new System.EventHandler(this.tsiBgColor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtServer);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSubscribe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSubTopic);
            this.panel1.Controls.Add(this.txtInterval);
            this.panel1.Controls.Add(this.rtbSubscribe);
            this.panel1.Controls.Add(this.txtPubTopic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbContinuous);
            this.panel1.Controls.Add(this.txtPublish);
            this.panel1.Controls.Add(this.btnPublish);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 562);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(806, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblConnectStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPubTopic;
        private System.Windows.Forms.TextBox txtPublish;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtSubTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblConnectStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.RichTextBox rtbSubscribe;
        private System.Windows.Forms.CheckBox cbContinuous;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miSettings;
        private System.Windows.Forms.ToolStripMenuItem tsiBgColor;
        private System.Windows.Forms.Panel panel1;
    }
}

