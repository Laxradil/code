
namespace simplelogin
{
    partial class SIGNUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNUP));
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_Loginhere = new System.Windows.Forms.Label();
            this.signup_close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_fullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(175, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label.Location = new System.Drawing.Point(436, 109);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(162, 37);
            this.label.TabIndex = 1;
            this.label.Text = "GET STARTED";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // signup_username
            // 
            this.signup_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signup_username.Location = new System.Drawing.Point(179, 376);
            this.signup_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(627, 40);
            this.signup_username.TabIndex = 2;
            this.signup_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(177, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "PASSWORD:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // signup_password
            // 
            this.signup_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signup_password.Location = new System.Drawing.Point(181, 460);
            this.signup_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.Size = new System.Drawing.Size(627, 40);
            this.signup_password.TabIndex = 4;
            this.signup_password.Click += new System.EventHandler(this.signup_password_TextChanged);
            this.signup_password.TextChanged += new System.EventHandler(this.signup_password_TextChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.Location = new System.Drawing.Point(380, 519);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(269, 39);
            this.signup_btn.TabIndex = 8;
            this.signup_btn.Text = "SIGNUP";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already Have an Account?";
            // 
            // signup_Loginhere
            // 
            this.signup_Loginhere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_Loginhere.AutoSize = true;
            this.signup_Loginhere.ForeColor = System.Drawing.SystemColors.Highlight;
            this.signup_Loginhere.Location = new System.Drawing.Point(731, 598);
            this.signup_Loginhere.Name = "signup_Loginhere";
            this.signup_Loginhere.Size = new System.Drawing.Size(102, 17);
            this.signup_Loginhere.TabIndex = 11;
            this.signup_Loginhere.Text = "Back to LOGIN";
            this.signup_Loginhere.Click += new System.EventHandler(this.label6_Click);
            // 
            // signup_close
            // 
            this.signup_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_close.AutoSize = true;
            this.signup_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_close.Location = new System.Drawing.Point(911, 30);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(37, 36);
            this.signup_close.TabIndex = 14;
            this.signup_close.Text = "X";
            this.signup_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, -104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // signup_email
            // 
            this.signup_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signup_email.Location = new System.Drawing.Point(179, 289);
            this.signup_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signup_email.Multiline = true;
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(627, 40);
            this.signup_email.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(177, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "EMAIL:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // signup_fullname
            // 
            this.signup_fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signup_fullname.Location = new System.Drawing.Point(179, 213);
            this.signup_fullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signup_fullname.Multiline = true;
            this.signup_fullname.Name = "signup_fullname";
            this.signup_fullname.Size = new System.Drawing.Size(627, 40);
            this.signup_fullname.TabIndex = 18;
            this.signup_fullname.TextChanged += new System.EventHandler(this.signup_fullname_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(175, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "FULL NAME:";
            // 
            // SIGNUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1003, 652);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup_fullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signup_email);
            this.Controls.Add(this.signup_close);
            this.Controls.Add(this.signup_Loginhere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SIGNUP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGNUP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label signup_Loginhere;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signup_fullname;
        private System.Windows.Forms.Label label4;
    }
}