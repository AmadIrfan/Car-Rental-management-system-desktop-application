namespace uiProject
{
    partial class Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.btnBack = new System.Windows.Forms.Button();
            this.GVCustomers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Panel();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.lbltopname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.Location = new System.Drawing.Point(45, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 33);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GVCustomers
            // 
            this.GVCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GVCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GVCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            this.GVCustomers.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GVCustomers.Location = new System.Drawing.Point(120, 99);
            this.GVCustomers.MultiSelect = false;
            this.GVCustomers.Name = "GVCustomers";
            this.GVCustomers.ReadOnly = true;
            this.GVCustomers.Size = new System.Drawing.Size(836, 420);
            this.GVCustomers.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblManageUsers);
            this.panel1.Controls.Add(this.lbltopname);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 75);
            this.panel1.TabIndex = 27;
            // 
            // lblExit
            // 
            this.lblExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblExit.BackgroundImage")));
            this.lblExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExit.Location = new System.Drawing.Point(1016, 21);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(30, 26);
            this.lblExit.TabIndex = 15;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblManageUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManageUsers.Location = new System.Drawing.Point(466, 45);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(105, 24);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "Customers";
            // 
            // lbltopname
            // 
            this.lbltopname.AutoSize = true;
            this.lbltopname.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltopname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltopname.Location = new System.Drawing.Point(302, 5);
            this.lbltopname.Name = "lbltopname";
            this.lbltopname.Size = new System.Drawing.Size(393, 40);
            this.lbltopname.TabIndex = 0;
            this.lbltopname.Text = "CAR RENTAL SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(-1, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 15);
            this.panel2.TabIndex = 28;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 602);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.GVCustomers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView GVCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lblExit;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.Label lbltopname;
        private System.Windows.Forms.Panel panel2;
    }
}