namespace uiProject
{
    partial class UserDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Panel();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.lbltopname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblnamecars = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblcarnumber = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblManageUsers);
            this.panel1.Controls.Add(this.lbltopname);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 75);
            this.panel1.TabIndex = 2;
            // 
            // lblExit
            // 
            this.lblExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblExit.BackgroundImage")));
            this.lblExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExit.Location = new System.Drawing.Point(962, 19);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(30, 26);
            this.lblExit.TabIndex = 11;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManageUsers.Location = new System.Drawing.Point(417, 45);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(111, 24);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "DashBoard";
            // 
            // lbltopname
            // 
            this.lbltopname.AutoSize = true;
            this.lbltopname.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltopname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltopname.Location = new System.Drawing.Point(280, 5);
            this.lbltopname.Name = "lbltopname";
            this.lbltopname.Size = new System.Drawing.Size(393, 40);
            this.lbltopname.TabIndex = 0;
            this.lbltopname.Text = "CAR RENTAL SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 15);
            this.panel2.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel9.Controls.Add(this.lblnamecars);
            this.panel9.Location = new System.Drawing.Point(402, 308);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(214, 139);
            this.panel9.TabIndex = 24;
            // 
            // lblnamecars
            // 
            this.lblnamecars.AutoSize = true;
            this.lblnamecars.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamecars.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnamecars.Location = new System.Drawing.Point(-6, 37);
            this.lblnamecars.Name = "lblnamecars";
            this.lblnamecars.Size = new System.Drawing.Size(161, 31);
            this.lblnamecars.TabIndex = 0;
            this.lblnamecars.Text = "Rented Cars";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel3.Controls.Add(this.lblcarnumber);
            this.panel3.Location = new System.Drawing.Point(375, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 180);
            this.panel3.TabIndex = 25;
            // 
            // lblcarnumber
            // 
            this.lblcarnumber.AutoSize = true;
            this.lblcarnumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarnumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcarnumber.Location = new System.Drawing.Point(178, 125);
            this.lblcarnumber.Name = "lblcarnumber";
            this.lblcarnumber.Size = new System.Drawing.Size(63, 24);
            this.lblcarnumber.TabIndex = 0;
            this.lblcarnumber.Text = "label2";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(421, 543);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(221, 43);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(512, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(373, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(251, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(87, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "User Name :";
            // 
            // UserDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDash";
            this.Text = "UserDash";
            this.Load += new System.EventHandler(this.UserDash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lblExit;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.Label lbltopname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblnamecars;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblcarnumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}