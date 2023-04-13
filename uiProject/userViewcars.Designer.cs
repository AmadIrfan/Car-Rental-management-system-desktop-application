namespace uiProject
{
    partial class userViewcars
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblMainForm = new System.Windows.Forms.Label();
            this.lbltopname = new System.Windows.Forms.Label();
            this.btnDeshboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.GVusercars = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVusercars)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblMainForm);
            this.panel1.Controls.Add(this.lbltopname);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 79);
            this.panel1.TabIndex = 9;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(839, 2);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 33);
            this.lblExit.TabIndex = 14;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblMainForm
            // 
            this.lblMainForm.AutoSize = true;
            this.lblMainForm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMainForm.Location = new System.Drawing.Point(377, 51);
            this.lblMainForm.Name = "lblMainForm";
            this.lblMainForm.Size = new System.Drawing.Size(67, 24);
            this.lblMainForm.TabIndex = 1;
            this.lblMainForm.Text = "CARS\r\n";
            // 
            // lbltopname
            // 
            this.lbltopname.AutoSize = true;
            this.lbltopname.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltopname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltopname.Location = new System.Drawing.Point(236, 5);
            this.lbltopname.Name = "lbltopname";
            this.lbltopname.Size = new System.Drawing.Size(393, 40);
            this.lbltopname.TabIndex = 0;
            this.lbltopname.Text = "CAR RENTAL SYSTEM";
            // 
            // btnDeshboard
            // 
            this.btnDeshboard.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeshboard.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDeshboard.FlatAppearance.BorderSize = 3;
            this.btnDeshboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnDeshboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDeshboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDeshboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeshboard.Location = new System.Drawing.Point(12, 109);
            this.btnDeshboard.Name = "btnDeshboard";
            this.btnDeshboard.Size = new System.Drawing.Size(225, 39);
            this.btnDeshboard.TabIndex = 14;
            this.btnDeshboard.Text = "Dashboard";
            this.btnDeshboard.UseVisualStyleBackColor = false;
            this.btnDeshboard.Click += new System.EventHandler(this.btnDeshboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(-2, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 17);
            this.panel2.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(731, 547);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 33);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GVusercars
            // 
            this.GVusercars.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GVusercars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVusercars.Location = new System.Drawing.Point(12, 154);
            this.GVusercars.Name = "GVusercars";
            this.GVusercars.ReadOnly = true;
            this.GVusercars.Size = new System.Drawing.Size(836, 372);
            this.GVusercars.TabIndex = 18;
            // 
            // userViewcars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 598);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.GVusercars);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeshboard);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userViewcars";
            this.Text = "userViewcars";
            this.Load += new System.EventHandler(this.userViewcars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVusercars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblMainForm;
        private System.Windows.Forms.Label lbltopname;
        private System.Windows.Forms.Button btnDeshboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView GVusercars;
    }
}