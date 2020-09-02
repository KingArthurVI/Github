namespace Witron_Login_2._0
{
    partial class witronlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(witronlogin));
            this.wiossPic = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.loginButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wiossPic)).BeginInit();
            this.SuspendLayout();
            // 
            // wiossPic
            // 
            this.wiossPic.Image = ((System.Drawing.Image)(resources.GetObject("wiossPic.Image")));
            this.wiossPic.Location = new System.Drawing.Point(12, 12);
            this.wiossPic.Name = "wiossPic";
            this.wiossPic.Size = new System.Drawing.Size(310, 111);
            this.wiossPic.TabIndex = 0;
            this.wiossPic.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(67, 171);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(63, 15);
            this.username.TabIndex = 1;
            this.username.Text = "Username:";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(136, 168);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(100, 23);
            this.userTxt.TabIndex = 2;
            this.userTxt.TextChanged += new System.EventHandler(this.userTxt_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(70, 212);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(60, 15);
            this.password.TabIndex = 3;
            this.password.Text = "Password:";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(136, 209);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(100, 23);
            this.passwordtxt.TabIndex = 4;
            this.passwordtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loginButt
            // 
            this.loginButt.Location = new System.Drawing.Point(136, 253);
            this.loginButt.Name = "loginButt";
            this.loginButt.Size = new System.Drawing.Size(75, 23);
            this.loginButt.TabIndex = 5;
            this.loginButt.Text = "Login";
            this.loginButt.UseVisualStyleBackColor = true;
            this.loginButt.Click += new System.EventHandler(this.loginButt_Click);
            // 
            // witronlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 369);
            this.Controls.Add(this.loginButt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.username);
            this.Controls.Add(this.wiossPic);
            this.Name = "witronlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Witron Login";
            ((System.ComponentModel.ISupportInitialize)(this.wiossPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wiossPic;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button loginButt;
    }
}

