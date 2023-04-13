namespace uiProject
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblcrs = new System.Windows.Forms.Label();
            this.txtUnameInput = new System.Windows.Forms.TextBox();
            this.lblUpass = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFpass = new System.Windows.Forms.LinkLabel();
            this.lblUfp = new System.Windows.Forms.Label();
            this.lblCreateAcut = new System.Windows.Forms.LinkLabel();
            this.lblError = new System.Windows.Forms.Label();
            this.CbShowPass = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblcrs);
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 46);
            this.panel1.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(498, 4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 33);
            this.lblExit.TabIndex = 13;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.label1_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lblcrs
            // 
            this.lblcrs.AutoSize = true;
            this.lblcrs.Font = new System.Drawing.Font("Times New Roman", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcrs.Location = new System.Drawing.Point(28, 0);
            this.lblcrs.Name = "lblcrs";
            this.lblcrs.Size = new System.Drawing.Size(272, 38);
            this.lblcrs.TabIndex = 2;
            this.lblcrs.Text = "Car Rental System";
            // 
            // txtUnameInput
            // 
            this.txtUnameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnameInput.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnameInput.Location = new System.Drawing.Point(337, 66);
            this.txtUnameInput.Name = "txtUnameInput";
            this.txtUnameInput.Size = new System.Drawing.Size(261, 22);
            this.txtUnameInput.TabIndex = 1;
            this.txtUnameInput.TextChanged += new System.EventHandler(this.txtUnameInput_TextChanged);
            // 
            // lblUpass
            // 
            this.lblUpass.AutoSize = true;
            this.lblUpass.BackColor = System.Drawing.Color.Transparent;
            this.lblUpass.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUpass.Location = new System.Drawing.Point(234, 129);
            this.lblUpass.Name = "lblUpass";
            this.lblUpass.Size = new System.Drawing.Size(86, 22);
            this.lblUpass.TabIndex = 5;
            this.lblUpass.Text = "Password";
            this.lblUpass.Click += new System.EventHandler(this.lblUpass_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(337, 125);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxPassword.Size = new System.Drawing.Size(261, 22);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.ForeColor = System.Drawing.Color.Snow;
            this.panel3.Location = new System.Drawing.Point(337, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 2);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.ForeColor = System.Drawing.Color.Snow;
            this.panel4.Location = new System.Drawing.Point(337, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 2);
            this.panel4.TabIndex = 7;
            // 
            // lblFpass
            // 
            this.lblFpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFpass.AutoSize = true;
            this.lblFpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFpass.Location = new System.Drawing.Point(413, 169);
            this.lblFpass.Name = "lblFpass";
            this.lblFpass.Size = new System.Drawing.Size(75, 19);
            this.lblFpass.TabIndex = 4;
            this.lblFpass.TabStop = true;
            this.lblFpass.Text = "Click Here";
            this.lblFpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUfClick_LinkClicked);
            // 
            // lblUfp
            // 
            this.lblUfp.AutoSize = true;
            this.lblUfp.BackColor = System.Drawing.Color.Transparent;
            this.lblUfp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUfp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUfp.Location = new System.Drawing.Point(288, 169);
            this.lblUfp.Name = "lblUfp";
            this.lblUfp.Size = new System.Drawing.Size(119, 19);
            this.lblUfp.TabIndex = 11;
            this.lblUfp.Text = "Terms & Conditions";
            // 
            // lblCreateAcut
            // 
            this.lblCreateAcut.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCreateAcut.AutoSize = true;
            this.lblCreateAcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreateAcut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAcut.Location = new System.Drawing.Point(388, 204);
            this.lblCreateAcut.Name = "lblCreateAcut";
            this.lblCreateAcut.Size = new System.Drawing.Size(119, 19);
            this.lblCreateAcut.TabIndex = 5;
            this.lblCreateAcut.TabStop = true;
            this.lblCreateAcut.Text = "Create an account";
            this.lblCreateAcut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreateAcut_LinkClicked);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(222, 273);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 16);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "label1";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // CbShowPass
            // 
            this.CbShowPass.AutoSize = true;
            this.CbShowPass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CbShowPass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CbShowPass.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.CbShowPass.Location = new System.Drawing.Point(497, 154);
            this.CbShowPass.Name = "CbShowPass";
            this.CbShowPass.Size = new System.Drawing.Size(102, 17);
            this.CbShowPass.TabIndex = 3;
            this.CbShowPass.Text = "Show Password";
            this.CbShowPass.UseVisualStyleBackColor = true;
            this.CbShowPass.CheckedChanged += new System.EventHandler(this.CbShowPass_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRefresh.FlatAppearance.BorderSize = 3;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(497, 236);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 37);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(303, 236);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 37);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.BackColor = System.Drawing.Color.Transparent;
            this.lblUname.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUname.Location = new System.Drawing.Point(225, 74);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(103, 22);
            this.lblUname.TabIndex = 3;
            this.lblUname.Text = "User Name ";
            this.lblUname.Click += new System.EventHandler(this.lblUname_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 302);
            this.panel2.TabIndex = 1;
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 299);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.CbShowPass);
            this.Controls.Add(this.lblCreateAcut);
            this.Controls.Add(this.lblUfp);
            this.Controls.Add(this.lblFpass);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblUpass);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.txtUnameInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loginform";
            this.Text = "Car Rental System ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcrs;
        private System.Windows.Forms.TextBox txtUnameInput;
        private System.Windows.Forms.Label lblUpass;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel lblFpass;
        private System.Windows.Forms.Label lblUfp;
        private System.Windows.Forms.LinkLabel lblCreateAcut;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox CbShowPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblUname;
    }
}

