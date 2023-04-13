namespace uiProject
{
    partial class mainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainpage));
            this.btnLogin = new System.Windows.Forms.Panel();
            this.Btnsignup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGray;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.Controls.Add(this.Btnsignup);
            this.btnLogin.Controls.Add(this.button1);
            this.btnLogin.Location = new System.Drawing.Point(-2, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(801, 309);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLogin_Paint);
            // 
            // Btnsignup
            // 
            this.Btnsignup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btnsignup.FlatAppearance.BorderSize = 3;
            this.Btnsignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btnsignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btnsignup.Location = new System.Drawing.Point(593, 125);
            this.Btnsignup.Name = "Btnsignup";
            this.Btnsignup.Size = new System.Drawing.Size(165, 41);
            this.Btnsignup.TabIndex = 1;
            this.Btnsignup.Text = "Sign Up";
            this.Btnsignup.UseVisualStyleBackColor = true;
            this.Btnsignup.Click += new System.EventHandler(this.Btnsignup_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(71, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainpage";
            this.Text = "mainpage";
            this.Load += new System.EventHandler(this.mainpage_Load);
            this.btnLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnLogin;
        private System.Windows.Forms.Button Btnsignup;
        private System.Windows.Forms.Button button1;
    }
}