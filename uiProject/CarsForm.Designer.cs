namespace uiProject
{
    partial class CarsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.GVcars = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBoxbrand = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Panel();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.lbltopname = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtBoxClass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxcolor = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBoxppd = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtBoxmodel = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxRnum = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblavail = new System.Windows.Forms.Label();
            this.cBoxavail = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GVcars)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(825, 552);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 33);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(673, 552);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 33);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btndelete.FlatAppearance.BorderSize = 3;
            this.btndelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.Location = new System.Drawing.Point(508, 552);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(117, 33);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // GVcars
            // 
            this.GVcars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GVcars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVcars.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GVcars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GVcars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVcars.DefaultCellStyle = dataGridViewCellStyle3;
            this.GVcars.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GVcars.Location = new System.Drawing.Point(349, 105);
            this.GVcars.MultiSelect = false;
            this.GVcars.Name = "GVcars";
            this.GVcars.ReadOnly = true;
            this.GVcars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVcars.Size = new System.Drawing.Size(697, 420);
            this.GVcars.TabIndex = 25;
            this.GVcars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVcars_CellContentClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(6, 113);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(232, 3);
            this.panel9.TabIndex = 66;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(7, 362);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(232, 3);
            this.panel7.TabIndex = 67;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBrand.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBrand.Location = new System.Drawing.Point(7, 64);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(53, 20);
            this.lblBrand.TabIndex = 65;
            this.lblBrand.Text = "Brand";
            // 
            // txtBoxbrand
            // 
            this.txtBoxbrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxbrand.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxbrand.ForeColor = System.Drawing.Color.Black;
            this.txtBoxbrand.Location = new System.Drawing.Point(7, 87);
            this.txtBoxbrand.Name = "txtBoxbrand";
            this.txtBoxbrand.Size = new System.Drawing.Size(231, 25);
            this.txtBoxbrand.TabIndex = 2;
            this.txtBoxbrand.TextChanged += new System.EventHandler(this.txtBoxbrand_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(6, 302);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(232, 3);
            this.panel6.TabIndex = 66;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(7, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 3);
            this.panel4.TabIndex = 65;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(7, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 3);
            this.panel5.TabIndex = 64;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(6, 58);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(232, 3);
            this.panel8.TabIndex = 63;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnadd.FlatAppearance.BorderSize = 3;
            this.btnadd.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.Location = new System.Drawing.Point(352, 552);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(117, 33);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
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
            this.panel1.Size = new System.Drawing.Size(1065, 75);
            this.panel1.TabIndex = 22;
            // 
            // lblExit
            // 
            this.lblExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblExit.BackgroundImage")));
            this.lblExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExit.Location = new System.Drawing.Point(1016, 19);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(30, 26);
            this.lblExit.TabIndex = 15;
            this.lblExit.Click += new System.EventHandler(this.panel10_Click);
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblManageUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManageUsers.Location = new System.Drawing.Point(466, 45);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(129, 24);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "Menage Cars";
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
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblClass.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClass.Location = new System.Drawing.Point(7, 314);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(47, 20);
            this.lblClass.TabIndex = 58;
            this.lblClass.Text = "Class";
            // 
            // txtBoxClass
            // 
            this.txtBoxClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxClass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClass.Location = new System.Drawing.Point(7, 340);
            this.txtBoxClass.Name = "txtBoxClass";
            this.txtBoxClass.Size = new System.Drawing.Size(231, 25);
            this.txtBoxClass.TabIndex = 6;
            this.txtBoxClass.TextChanged += new System.EventHandler(this.txtBoxCpass_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(7, 257);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 20);
            this.lblPassword.TabIndex = 57;
            this.lblPassword.Text = "Color";
            // 
            // txtBoxcolor
            // 
            this.txtBoxcolor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxcolor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxcolor.Location = new System.Drawing.Point(7, 280);
            this.txtBoxcolor.Name = "txtBoxcolor";
            this.txtBoxcolor.Size = new System.Drawing.Size(231, 25);
            this.txtBoxcolor.TabIndex = 5;
            this.txtBoxcolor.TextChanged += new System.EventHandler(this.txtBoxcolor_TextChanged);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAge.Location = new System.Drawing.Point(7, 188);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(91, 20);
            this.lblAge.TabIndex = 56;
            this.lblAge.Text = "Price / Day";
            // 
            // txtBoxppd
            // 
            this.txtBoxppd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxppd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxppd.ForeColor = System.Drawing.Color.Black;
            this.txtBoxppd.Location = new System.Drawing.Point(7, 211);
            this.txtBoxppd.Name = "txtBoxppd";
            this.txtBoxppd.Size = new System.Drawing.Size(231, 25);
            this.txtBoxppd.TabIndex = 4;
            this.txtBoxppd.TextChanged += new System.EventHandler(this.txtBoxppd_TextChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblModel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModel.Location = new System.Drawing.Point(7, 130);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(55, 20);
            this.lblModel.TabIndex = 55;
            this.lblModel.Text = "Model";
            // 
            // txtBoxmodel
            // 
            this.txtBoxmodel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxmodel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxmodel.ForeColor = System.Drawing.Color.Black;
            this.txtBoxmodel.Location = new System.Drawing.Point(7, 153);
            this.txtBoxmodel.Name = "txtBoxmodel";
            this.txtBoxmodel.Size = new System.Drawing.Size(231, 25);
            this.txtBoxmodel.TabIndex = 3;
            this.txtBoxmodel.TextChanged += new System.EventHandler(this.txtBoxmodel_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(7, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 20);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Reg Number";
            // 
            // txtboxRnum
            // 
            this.txtboxRnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxRnum.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRnum.ForeColor = System.Drawing.Color.Black;
            this.txtboxRnum.Location = new System.Drawing.Point(7, 32);
            this.txtboxRnum.Name = "txtboxRnum";
            this.txtboxRnum.Size = new System.Drawing.Size(231, 25);
            this.txtboxRnum.TabIndex = 1;
            this.txtboxRnum.TextChanged += new System.EventHandler(this.txtboxName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblavail);
            this.panel3.Controls.Add(this.cBoxavail);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.lblBrand);
            this.panel3.Controls.Add(this.txtBoxbrand);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.lblClass);
            this.panel3.Controls.Add(this.txtBoxClass);
            this.panel3.Controls.Add(this.lblPassword);
            this.panel3.Controls.Add(this.txtBoxcolor);
            this.panel3.Controls.Add(this.lblAge);
            this.panel3.Controls.Add(this.txtBoxppd);
            this.panel3.Controls.Add(this.lblModel);
            this.panel3.Controls.Add(this.txtBoxmodel);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.txtboxRnum);
            this.panel3.Location = new System.Drawing.Point(31, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 489);
            this.panel3.TabIndex = 24;
            // 
            // lblavail
            // 
            this.lblavail.AutoSize = true;
            this.lblavail.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblavail.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblavail.Location = new System.Drawing.Point(7, 379);
            this.lblavail.Name = "lblavail";
            this.lblavail.Size = new System.Drawing.Size(74, 20);
            this.lblavail.TabIndex = 69;
            this.lblavail.Text = "Available";
            // 
            // cBoxavail
            // 
            this.cBoxavail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxavail.FormattingEnabled = true;
            this.cBoxavail.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cBoxavail.Location = new System.Drawing.Point(11, 402);
            this.cBoxavail.Name = "cBoxavail";
            this.cBoxavail.Size = new System.Drawing.Size(227, 29);
            this.cBoxavail.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 15);
            this.panel2.TabIndex = 23;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 620);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.GVcars);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsForm";
            this.Text = "7";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVcars)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView GVcars;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBoxbrand;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.Label lbltopname;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtBoxClass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxcolor;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBoxppd;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtBoxmodel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxRnum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblavail;
        private System.Windows.Forms.ComboBox cBoxavail;
        private System.Windows.Forms.Panel lblExit;
    }
}