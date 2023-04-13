namespace uiProject
{
    partial class user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Panel();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.lbltopname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblGander = new System.Windows.Forms.Label();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.lblRoll = new System.Windows.Forms.Label();
            this.Cbox = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lblPnumber = new System.Windows.Forms.Label();
            this.txtBoxPnumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.GVusers = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVusers)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1007, 75);
            this.panel1.TabIndex = 1;
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
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click_1);
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManageUsers.Location = new System.Drawing.Point(446, 45);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(136, 24);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "Menage Users";
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
            this.panel2.Location = new System.Drawing.Point(-1, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 15);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtBoxId);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.lblGander);
            this.panel3.Controls.Add(this.radioBtnFemale);
            this.panel3.Controls.Add(this.radioBtnMale);
            this.panel3.Controls.Add(this.lblRoll);
            this.panel3.Controls.Add(this.Cbox);
            this.panel3.Controls.Add(this.lblPassword);
            this.panel3.Controls.Add(this.txtBoxPassword);
            this.panel3.Controls.Add(this.lblAge);
            this.panel3.Controls.Add(this.txtBoxAge);
            this.panel3.Controls.Add(this.lblPnumber);
            this.panel3.Controls.Add(this.txtBoxPnumber);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.txtboxName);
            this.panel3.Location = new System.Drawing.Point(5, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 429);
            this.panel3.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(6, 113);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(232, 3);
            this.panel9.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.ForeColor = System.Drawing.Color.Black;
            this.txtBoxId.Location = new System.Drawing.Point(7, 87);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(231, 25);
            this.txtBoxId.TabIndex = 2;
            this.txtBoxId.TextChanged += new System.EventHandler(this.txtBoxId_TextChanged);
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
            // lblGander
            // 
            this.lblGander.AutoSize = true;
            this.lblGander.BackColor = System.Drawing.Color.Transparent;
            this.lblGander.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGander.Location = new System.Drawing.Point(7, 394);
            this.lblGander.Name = "lblGander";
            this.lblGander.Size = new System.Drawing.Size(62, 20);
            this.lblGander.TabIndex = 62;
            this.lblGander.Text = "Gender";
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnFemale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnFemale.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFemale.Location = new System.Drawing.Point(155, 392);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(79, 24);
            this.radioBtnFemale.TabIndex = 9;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = false;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnMale.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMale.Location = new System.Drawing.Point(75, 392);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(63, 24);
            this.radioBtnMale.TabIndex = 8;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = false;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRoll.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoll.Location = new System.Drawing.Point(7, 326);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(42, 20);
            this.lblRoll.TabIndex = 59;
            this.lblRoll.Text = "Role";
            // 
            // Cbox
            // 
            this.Cbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox.FormattingEnabled = true;
            this.Cbox.ItemHeight = 23;
            this.Cbox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.Cbox.Location = new System.Drawing.Point(8, 349);
            this.Cbox.Name = "Cbox";
            this.Cbox.Size = new System.Drawing.Size(231, 31);
            this.Cbox.TabIndex = 53;
            this.Cbox.Text = "Select...";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(7, 257);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 20);
            this.lblPassword.TabIndex = 57;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(7, 280);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(231, 25);
            this.txtBoxPassword.TabIndex = 5;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAge.Location = new System.Drawing.Point(7, 188);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(46, 20);
            this.lblAge.TabIndex = 56;
            this.lblAge.Text = "Age :";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAge.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAge.ForeColor = System.Drawing.Color.Black;
            this.txtBoxAge.Location = new System.Drawing.Point(7, 211);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(231, 25);
            this.txtBoxAge.TabIndex = 4;
            this.txtBoxAge.TextChanged += new System.EventHandler(this.txtBoxAge_TextChanged);
            // 
            // lblPnumber
            // 
            this.lblPnumber.AutoSize = true;
            this.lblPnumber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPnumber.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPnumber.Location = new System.Drawing.Point(7, 130);
            this.lblPnumber.Name = "lblPnumber";
            this.lblPnumber.Size = new System.Drawing.Size(119, 20);
            this.lblPnumber.TabIndex = 55;
            this.lblPnumber.Text = "Phone Number";
            // 
            // txtBoxPnumber
            // 
            this.txtBoxPnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPnumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPnumber.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPnumber.Location = new System.Drawing.Point(7, 153);
            this.txtBoxPnumber.Name = "txtBoxPnumber";
            this.txtBoxPnumber.Size = new System.Drawing.Size(231, 25);
            this.txtBoxPnumber.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(7, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 20);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Name :";
            // 
            // txtboxName
            // 
            this.txtboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.ForeColor = System.Drawing.Color.Black;
            this.txtboxName.Location = new System.Drawing.Point(7, 32);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(231, 25);
            this.txtboxName.TabIndex = 1;
            // 
            // GVusers
            // 
            this.GVusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GVusers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVusers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GVusers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GVusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVusers.DefaultCellStyle = dataGridViewCellStyle1;
            this.GVusers.Location = new System.Drawing.Point(323, 90);
            this.GVusers.Name = "GVusers";
            this.GVusers.ReadOnly = true;
            this.GVusers.Size = new System.Drawing.Size(669, 420);
            this.GVusers.TabIndex = 17;
            this.GVusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVusers_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(815, 525);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 33);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(668, 525);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 33);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btndelete.FlatAppearance.BorderSize = 3;
            this.btndelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndelete.Location = new System.Drawing.Point(499, 525);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(117, 33);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnadd.FlatAppearance.BorderSize = 3;
            this.btnadd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadd.Location = new System.Drawing.Point(343, 525);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(117, 33);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1004, 592);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.GVusers);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(30, 48);
            this.Name = "user";
            this.Text = "ViewUsers";
            this.Load += new System.EventHandler(this.ViewUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVusers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.Label lbltopname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblGander;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.ComboBox Cbox;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label lblPnumber;
        private System.Windows.Forms.TextBox txtBoxPnumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.DataGridView GVusers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Panel lblExit;
    }
}