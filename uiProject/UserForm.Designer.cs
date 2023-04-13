namespace uiProject
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.lblExit = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMainForm = new System.Windows.Forms.Label();
            this.lbltopname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnBookCars = new System.Windows.Forms.Button();
            this.btnDeshboard = new System.Windows.Forms.Button();
            this.btnPrivious = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btncars = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblExit.BackgroundImage")));
            this.lblExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExit.Location = new System.Drawing.Point(1007, 19);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(30, 26);
            this.lblExit.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblMainForm);
            this.panel1.Controls.Add(this.lbltopname);
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 79);
            this.panel1.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(932, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 26);
            this.panel5.TabIndex = 11;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // lblMainForm
            // 
            this.lblMainForm.AutoSize = true;
            this.lblMainForm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMainForm.Location = new System.Drawing.Point(488, 51);
            this.lblMainForm.Name = "lblMainForm";
            this.lblMainForm.Size = new System.Drawing.Size(101, 24);
            this.lblMainForm.TabIndex = 1;
            this.lblMainForm.Text = "UserForm\r\n";
            // 
            // lbltopname
            // 
            this.lbltopname.AutoSize = true;
            this.lbltopname.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltopname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltopname.Location = new System.Drawing.Point(347, 5);
            this.lbltopname.Name = "lbltopname";
            this.lbltopname.Size = new System.Drawing.Size(393, 40);
            this.lbltopname.TabIndex = 0;
            this.lbltopname.Text = "CAR RENTAL SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(-3, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 15);
            this.panel2.TabIndex = 11;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnlogout.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnlogout.FlatAppearance.BorderSize = 3;
            this.btnlogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogout.Location = new System.Drawing.Point(1, 300);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(217, 70);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // btnBookCars
            // 
            this.btnBookCars.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBookCars.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBookCars.FlatAppearance.BorderSize = 3;
            this.btnBookCars.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnBookCars.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnBookCars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnBookCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookCars.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookCars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBookCars.Location = new System.Drawing.Point(1, 167);
            this.btnBookCars.Name = "btnBookCars";
            this.btnBookCars.Size = new System.Drawing.Size(217, 70);
            this.btnBookCars.TabIndex = 3;
            this.btnBookCars.Text = "BOOK CARS";
            this.btnBookCars.UseVisualStyleBackColor = false;
            this.btnBookCars.Click += new System.EventHandler(this.btnBookCars_Click);
            // 
            // btnDeshboard
            // 
            this.btnDeshboard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeshboard.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDeshboard.FlatAppearance.BorderSize = 3;
            this.btnDeshboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnDeshboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDeshboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDeshboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeshboard.Location = new System.Drawing.Point(1, 32);
            this.btnDeshboard.Name = "btnDeshboard";
            this.btnDeshboard.Size = new System.Drawing.Size(217, 70);
            this.btnDeshboard.TabIndex = 5;
            this.btnDeshboard.Text = "DASHBOARD";
            this.btnDeshboard.UseVisualStyleBackColor = false;
            this.btnDeshboard.Click += new System.EventHandler(this.btnDeshboard_Click);
            // 
            // btnPrivious
            // 
            this.btnPrivious.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrivious.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPrivious.FlatAppearance.BorderSize = 3;
            this.btnPrivious.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnPrivious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnPrivious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnPrivious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivious.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrivious.Location = new System.Drawing.Point(1, 234);
            this.btnPrivious.Name = "btnPrivious";
            this.btnPrivious.Size = new System.Drawing.Size(217, 70);
            this.btnPrivious.TabIndex = 4;
            this.btnPrivious.Text = "PRIVIOUS RECORD";
            this.btnPrivious.UseVisualStyleBackColor = false;
            this.btnPrivious.Click += new System.EventHandler(this.btnPrivious_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.btncars);
            this.panel4.Controls.Add(this.btnlogout);
            this.panel4.Controls.Add(this.btnBookCars);
            this.panel4.Controls.Add(this.btnDeshboard);
            this.panel4.Controls.Add(this.btnPrivious);
            this.panel4.Location = new System.Drawing.Point(-1, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 511);
            this.panel4.TabIndex = 13;
            // 
            // btncars
            // 
            this.btncars.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncars.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btncars.FlatAppearance.BorderSize = 3;
            this.btncars.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btncars.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btncars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btncars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncars.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncars.Location = new System.Drawing.Point(1, 100);
            this.btncars.Name = "btncars";
            this.btncars.Size = new System.Drawing.Size(217, 70);
            this.btncars.TabIndex = 9;
            this.btncars.Text = "CARS";
            this.btncars.UseVisualStyleBackColor = false;
            this.btncars.Click += new System.EventHandler(this.btncars_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(406, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 351);
            this.panel3.TabIndex = 12;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMainForm;
        private System.Windows.Forms.Label lbltopname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnBookCars;
        private System.Windows.Forms.Button btnDeshboard;
        private System.Windows.Forms.Button btnPrivious;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btncars;
    }
}