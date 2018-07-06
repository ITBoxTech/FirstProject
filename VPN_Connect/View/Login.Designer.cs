namespace VPN_Connect
{
    partial class Login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.connect_vpn = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.IsConnected_label = new System.Windows.Forms.Label();
            this.checkState = new System.Windows.Forms.Button();
            this.disconnect_vpn = new System.Windows.Forms.Button();
            this.information_groupbox = new System.Windows.Forms.GroupBox();
            this.state_pictureBox = new System.Windows.Forms.PictureBox();
            this.final_update_label = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.extra_info_label = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.LinkLabel();
            this.information_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.state_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Georgia", 10F);
            this.username.Location = new System.Drawing.Point(118, 49);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(193, 23);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Georgia", 10F);
            this.password.Location = new System.Drawing.Point(118, 84);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(193, 23);
            this.password.TabIndex = 1;
            // 
            // connect_vpn
            // 
            this.connect_vpn.Font = new System.Drawing.Font("Georgia", 12F);
            this.connect_vpn.Location = new System.Drawing.Point(28, 129);
            this.connect_vpn.Margin = new System.Windows.Forms.Padding(4);
            this.connect_vpn.Name = "connect_vpn";
            this.connect_vpn.Size = new System.Drawing.Size(130, 35);
            this.connect_vpn.TabIndex = 2;
            this.connect_vpn.Text = "Connect";
            this.connect_vpn.UseVisualStyleBackColor = true;
            this.connect_vpn.Click += new System.EventHandler(this.connect_vpn_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Georgia", 10F);
            this.label_username.Location = new System.Drawing.Point(25, 52);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(76, 17);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Georgia", 10F);
            this.label_password.Location = new System.Drawing.Point(29, 87);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(72, 17);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password:";
            // 
            // IsConnected_label
            // 
            this.IsConnected_label.AutoSize = true;
            this.IsConnected_label.Font = new System.Drawing.Font("Calibri", 9F);
            this.IsConnected_label.Location = new System.Drawing.Point(49, 208);
            this.IsConnected_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IsConnected_label.Name = "IsConnected_label";
            this.IsConnected_label.Size = new System.Drawing.Size(35, 14);
            this.IsConnected_label.TabIndex = 8;
            this.IsConnected_label.Text = "state";
            // 
            // checkState
            // 
            this.checkState.Location = new System.Drawing.Point(208, 201);
            this.checkState.Margin = new System.Windows.Forms.Padding(4);
            this.checkState.Name = "checkState";
            this.checkState.Size = new System.Drawing.Size(164, 29);
            this.checkState.TabIndex = 9;
            this.checkState.Text = "Check Connection State";
            this.checkState.UseVisualStyleBackColor = true;
            this.checkState.Click += new System.EventHandler(this.checkState_Click);
            // 
            // disconnect_vpn
            // 
            this.disconnect_vpn.Font = new System.Drawing.Font("Georgia", 12F);
            this.disconnect_vpn.Location = new System.Drawing.Point(181, 129);
            this.disconnect_vpn.Margin = new System.Windows.Forms.Padding(4);
            this.disconnect_vpn.Name = "disconnect_vpn";
            this.disconnect_vpn.Size = new System.Drawing.Size(130, 35);
            this.disconnect_vpn.TabIndex = 10;
            this.disconnect_vpn.Text = "Disconnect";
            this.disconnect_vpn.UseVisualStyleBackColor = true;
            this.disconnect_vpn.Click += new System.EventHandler(this.disconnect_vpn_Click);
            // 
            // information_groupbox
            // 
            this.information_groupbox.Controls.Add(this.username);
            this.information_groupbox.Controls.Add(this.disconnect_vpn);
            this.information_groupbox.Controls.Add(this.label_username);
            this.information_groupbox.Controls.Add(this.password);
            this.information_groupbox.Controls.Add(this.label_password);
            this.information_groupbox.Controls.Add(this.connect_vpn);
            this.information_groupbox.Font = new System.Drawing.Font("Georgia", 12F);
            this.information_groupbox.Location = new System.Drawing.Point(27, 12);
            this.information_groupbox.Name = "information_groupbox";
            this.information_groupbox.Size = new System.Drawing.Size(345, 187);
            this.information_groupbox.TabIndex = 11;
            this.information_groupbox.TabStop = false;
            this.information_groupbox.Text = "Please Enter VPN login information";
            // 
            // state_pictureBox
            // 
            this.state_pictureBox.Location = new System.Drawing.Point(24, 205);
            this.state_pictureBox.Name = "state_pictureBox";
            this.state_pictureBox.Size = new System.Drawing.Size(25, 25);
            this.state_pictureBox.TabIndex = 12;
            this.state_pictureBox.TabStop = false;
            // 
            // final_update_label
            // 
            this.final_update_label.AutoSize = true;
            this.final_update_label.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_update_label.Location = new System.Drawing.Point(205, 234);
            this.final_update_label.Name = "final_update_label";
            this.final_update_label.Size = new System.Drawing.Size(31, 14);
            this.final_update_label.TabIndex = 13;
            this.final_update_label.Text = "time";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Georgia", 8F);
            this.version.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.version.Location = new System.Drawing.Point(322, 263);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(73, 14);
            this.version.TabIndex = 14;
            this.version.Text = "Version 1.0";
            // 
            // extra_info_label
            // 
            this.extra_info_label.AutoSize = true;
            this.extra_info_label.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extra_info_label.Location = new System.Drawing.Point(21, 234);
            this.extra_info_label.Name = "extra_info_label";
            this.extra_info_label.Size = new System.Drawing.Size(58, 14);
            this.extra_info_label.TabIndex = 15;
            this.extra_info_label.Text = "Extra Info";
            // 
            // copyright
            // 
            this.copyright.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Georgia", 8F);
            this.copyright.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copyright.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.copyright.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copyright.Location = new System.Drawing.Point(2, 263);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(187, 14);
            this.copyright.TabIndex = 16;
            this.copyright.TabStop = true;
            this.copyright.Text = "copyright © IT BOX TECH.COM";
            this.copyright.VisitedLinkColor = System.Drawing.Color.Silver;
            this.copyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.copyright_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 280);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.extra_info_label);
            this.Controls.Add(this.version);
            this.Controls.Add(this.final_update_label);
            this.Controls.Add(this.state_pictureBox);
            this.Controls.Add(this.information_groupbox);
            this.Controls.Add(this.checkState);
            this.Controls.Add(this.IsConnected_label);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.information_groupbox.ResumeLayout(false);
            this.information_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.state_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button connect_vpn;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label IsConnected_label;
        private System.Windows.Forms.Button checkState;
        private System.Windows.Forms.Button disconnect_vpn;
        private System.Windows.Forms.GroupBox information_groupbox;
        private System.Windows.Forms.PictureBox state_pictureBox;
        private System.Windows.Forms.Label final_update_label;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label extra_info_label;
        private System.Windows.Forms.LinkLabel copyright;
    }
}

