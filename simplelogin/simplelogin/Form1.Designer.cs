
namespace simplelogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.login_showPassword = new System.Windows.Forms.CheckBox();
            this.login_registerCREATE = new System.Windows.Forms.Label();
            this.login_close = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(185, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(187, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_username
            // 
            this.login_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_username.Location = new System.Drawing.Point(321, 351);
            this.login_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(425, 35);
            this.login_username.TabIndex = 3;
            this.login_username.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // login_password
            // 
            this.login_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_password.Location = new System.Drawing.Point(321, 426);
            this.login_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '●';
            this.login_password.Size = new System.Drawing.Size(425, 22);
            this.login_password.TabIndex = 4;
            this.login_password.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // login_btn
            // 
            this.login_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(441, 497);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(177, 48);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.loginbutt_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(388, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "EDUMIND";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // login_showPassword
            // 
            this.login_showPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_showPassword.AutoSize = true;
            this.login_showPassword.Location = new System.Drawing.Point(771, 430);
            this.login_showPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_showPassword.Name = "login_showPassword";
            this.login_showPassword.Size = new System.Drawing.Size(129, 21);
            this.login_showPassword.TabIndex = 10;
            this.login_showPassword.Text = "Show Password";
            this.login_showPassword.UseVisualStyleBackColor = true;
            this.login_showPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login_registerCREATE
            // 
            this.login_registerCREATE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_registerCREATE.AutoSize = true;
            this.login_registerCREATE.ForeColor = System.Drawing.SystemColors.Highlight;
            this.login_registerCREATE.Location = new System.Drawing.Point(803, 626);
            this.login_registerCREATE.Name = "login_registerCREATE";
            this.login_registerCREATE.Size = new System.Drawing.Size(138, 17);
            this.login_registerCREATE.TabIndex = 12;
            this.login_registerCREATE.Text = "CREATE an Account";
            this.login_registerCREATE.Click += new System.EventHandler(this.label6_Click);
            // 
            // login_close
            // 
            this.login_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_close.AutoSize = true;
            this.login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.Location = new System.Drawing.Point(987, 11);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(37, 36);
            this.login_close.TabIndex = 13;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Don\'t Have an Account?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label.Location = new System.Drawing.Point(430, 247);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(195, 21);
            this.label.TabIndex = 14;
            this.label.Text = "STUDENT ASSISTANCE TOOL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, -128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1043, 693);
            this.Controls.Add(this.label);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.login_registerCREATE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login_showPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox login_showPassword;
        private System.Windows.Forms.Label login_registerCREATE;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
    }
}

