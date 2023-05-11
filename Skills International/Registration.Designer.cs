
namespace Skills_International
{
    partial class Registration
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
            this.labeltitle = new System.Windows.Forms.Label();
            this.labelregistrationno = new System.Windows.Forms.Label();
            this.labelfirstname = new System.Windows.Forms.Label();
            this.TextboxFName = new System.Windows.Forms.TextBox();
            this.labellastname = new System.Windows.Forms.Label();
            this.TextboxLName = new System.Windows.Forms.TextBox();
            this.labeldateofbirth = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.Label();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textboxaddress = new System.Windows.Forms.TextBox();
            this.textboxemail = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelmobile = new System.Windows.Forms.Label();
            this.textboxmobile = new System.Windows.Forms.TextBox();
            this.labelhome = new System.Windows.Forms.Label();
            this.textboxhome = new System.Windows.Forms.TextBox();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.labelParentname = new System.Windows.Forms.Label();
            this.labelNIC = new System.Windows.Forms.Label();
            this.labelContactnumber = new System.Windows.Forms.Label();
            this.textboxpname = new System.Windows.Forms.TextBox();
            this.textboxNIC = new System.Windows.Forms.TextBox();
            this.textboxCnumber = new System.Windows.Forms.TextBox();
            this.buttonregister = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.Linkexit = new System.Windows.Forms.LinkLabel();
            this.Linklogout = new System.Windows.Forms.LinkLabel();
            this.Groupboxregistration = new System.Windows.Forms.GroupBox();
            this.labelParentdetails = new System.Windows.Forms.GroupBox();
            this.labelContactdetails = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Groupboxregistration.SuspendLayout();
            this.labelParentdetails.SuspendLayout();
            this.labelContactdetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(254, 9);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(277, 38);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "Skills International";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelregistrationno
            // 
            this.labelregistrationno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelregistrationno.AutoSize = true;
            this.labelregistrationno.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelregistrationno.Location = new System.Drawing.Point(97, 36);
            this.labelregistrationno.Name = "labelregistrationno";
            this.labelregistrationno.Size = new System.Drawing.Size(75, 24);
            this.labelregistrationno.TabIndex = 1;
            this.labelregistrationno.Text = "Reg No";
            this.labelregistrationno.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelfirstname
            // 
            this.labelfirstname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelfirstname.AutoSize = true;
            this.labelfirstname.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstname.Location = new System.Drawing.Point(52, 34);
            this.labelfirstname.Name = "labelfirstname";
            this.labelfirstname.Size = new System.Drawing.Size(110, 24);
            this.labelfirstname.TabIndex = 3;
            this.labelfirstname.Text = "First Name";
            this.labelfirstname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TextboxFName
            // 
            this.TextboxFName.Location = new System.Drawing.Point(182, 30);
            this.TextboxFName.Name = "TextboxFName";
            this.TextboxFName.Size = new System.Drawing.Size(477, 30);
            this.TextboxFName.TabIndex = 4;
            this.TextboxFName.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // labellastname
            // 
            this.labellastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labellastname.AutoSize = true;
            this.labellastname.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellastname.Location = new System.Drawing.Point(56, 78);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(107, 24);
            this.labellastname.TabIndex = 5;
            this.labellastname.Text = "Last Name";
            this.labellastname.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // TextboxLName
            // 
            this.TextboxLName.Location = new System.Drawing.Point(182, 74);
            this.TextboxLName.Name = "TextboxLName";
            this.TextboxLName.Size = new System.Drawing.Size(477, 30);
            this.TextboxLName.TabIndex = 6;
            this.TextboxLName.TextChanged += new System.EventHandler(this.txtBox2_TextChanged_1);
            // 
            // labeldateofbirth
            // 
            this.labeldateofbirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labeldateofbirth.AutoSize = true;
            this.labeldateofbirth.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldateofbirth.Location = new System.Drawing.Point(39, 118);
            this.labeldateofbirth.Name = "labeldateofbirth";
            this.labeldateofbirth.Size = new System.Drawing.Size(126, 24);
            this.labeldateofbirth.TabIndex = 7;
            this.labeldateofbirth.Text = "Date of Birth";
            this.labeldateofbirth.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 118);
            this.dateTimePicker1.MaxDate = new System.DateTime(9950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 30);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2023, 2, 26, 11, 29, 19, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Gender
            // 
            this.Gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(88, 158);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(74, 24);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(182, 154);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(79, 29);
            this.radioBtnMale.TabIndex = 10;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            this.radioBtnMale.CheckedChanged += new System.EventHandler(this.radioBtn1_CheckedChanged);
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(305, 154);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(102, 29);
            this.radioBtnFemale.TabIndex = 11;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            this.radioBtnFemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(73, 38);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(82, 24);
            this.labelAddress.TabIndex = 12;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textboxaddress
            // 
            this.textboxaddress.Location = new System.Drawing.Point(182, 31);
            this.textboxaddress.Multiline = true;
            this.textboxaddress.Name = "textboxaddress";
            this.textboxaddress.Size = new System.Drawing.Size(477, 81);
            this.textboxaddress.TabIndex = 13;
            this.textboxaddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textboxemail
            // 
            this.textboxemail.Location = new System.Drawing.Point(182, 115);
            this.textboxemail.Name = "textboxemail";
            this.textboxemail.Size = new System.Drawing.Size(262, 30);
            this.textboxemail.TabIndex = 14;
            this.textboxemail.TextChanged += new System.EventHandler(this.txtBox4_TextChanged);
            // 
            // labelemail
            // 
            this.labelemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(86, 117);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(62, 24);
            this.labelemail.TabIndex = 15;
            this.labelemail.Text = "Email";
            this.labelemail.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelmobile
            // 
            this.labelmobile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelmobile.AutoSize = true;
            this.labelmobile.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmobile.Location = new System.Drawing.Point(30, 163);
            this.labelmobile.Name = "labelmobile";
            this.labelmobile.Size = new System.Drawing.Size(133, 24);
            this.labelmobile.TabIndex = 16;
            this.labelmobile.Text = "Mobile Phone";
            this.labelmobile.Click += new System.EventHandler(this.label4_Click);
            // 
            // textboxmobile
            // 
            this.textboxmobile.Location = new System.Drawing.Point(182, 161);
            this.textboxmobile.Name = "textboxmobile";
            this.textboxmobile.Size = new System.Drawing.Size(171, 30);
            this.textboxmobile.TabIndex = 17;
            this.textboxmobile.TextChanged += new System.EventHandler(this.txtBox5_TextChanged);
            // 
            // labelhome
            // 
            this.labelhome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelhome.AutoSize = true;
            this.labelhome.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhome.Location = new System.Drawing.Point(373, 164);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(125, 24);
            this.labelhome.TabIndex = 18;
            this.labelhome.Text = "Home Phone";
            this.labelhome.Click += new System.EventHandler(this.label5_Click);
            // 
            // textboxhome
            // 
            this.textboxhome.Location = new System.Drawing.Point(527, 161);
            this.textboxhome.Name = "textboxhome";
            this.textboxhome.Size = new System.Drawing.Size(171, 30);
            this.textboxhome.TabIndex = 19;
            this.textboxhome.TextChanged += new System.EventHandler(this.txtBox6_TextChanged);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(223, 31);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(149, 33);
            this.ComboBox.TabIndex = 20;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelParentname
            // 
            this.labelParentname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelParentname.AutoSize = true;
            this.labelParentname.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParentname.Location = new System.Drawing.Point(35, 33);
            this.labelParentname.Name = "labelParentname";
            this.labelParentname.Size = new System.Drawing.Size(128, 24);
            this.labelParentname.TabIndex = 21;
            this.labelParentname.Text = "Parent Name";
            this.labelParentname.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelNIC
            // 
            this.labelNIC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNIC.AutoSize = true;
            this.labelNIC.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIC.Location = new System.Drawing.Point(108, 75);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(41, 24);
            this.labelNIC.TabIndex = 22;
            this.labelNIC.Text = "NIC";
            this.labelNIC.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelContactnumber
            // 
            this.labelContactnumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelContactnumber.AutoSize = true;
            this.labelContactnumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactnumber.Location = new System.Drawing.Point(14, 118);
            this.labelContactnumber.Name = "labelContactnumber";
            this.labelContactnumber.Size = new System.Drawing.Size(156, 24);
            this.labelContactnumber.TabIndex = 23;
            this.labelContactnumber.Text = "Contact Number";
            this.labelContactnumber.Click += new System.EventHandler(this.label8_Click);
            // 
            // textboxpname
            // 
            this.textboxpname.Location = new System.Drawing.Point(196, 25);
            this.textboxpname.Name = "textboxpname";
            this.textboxpname.Size = new System.Drawing.Size(262, 30);
            this.textboxpname.TabIndex = 24;
            this.textboxpname.TextChanged += new System.EventHandler(this.txtBox7_TextChanged);
            // 
            // textboxNIC
            // 
            this.textboxNIC.Location = new System.Drawing.Point(196, 69);
            this.textboxNIC.Name = "textboxNIC";
            this.textboxNIC.Size = new System.Drawing.Size(262, 30);
            this.textboxNIC.TabIndex = 25;
            this.textboxNIC.TextChanged += new System.EventHandler(this.txtBox8_TextChanged);
            // 
            // textboxCnumber
            // 
            this.textboxCnumber.Location = new System.Drawing.Point(196, 114);
            this.textboxCnumber.Name = "textboxCnumber";
            this.textboxCnumber.Size = new System.Drawing.Size(262, 30);
            this.textboxCnumber.TabIndex = 26;
            this.textboxCnumber.TextChanged += new System.EventHandler(this.txtBox9_TextChanged);
            // 
            // buttonregister
            // 
            this.buttonregister.Location = new System.Drawing.Point(13, 662);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(134, 41);
            this.buttonregister.TabIndex = 27;
            this.buttonregister.Text = "Register";
            this.buttonregister.UseVisualStyleBackColor = true;
            this.buttonregister.Click += new System.EventHandler(this.btn1_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(153, 662);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(118, 41);
            this.buttonupdate.TabIndex = 28;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.btn2_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(548, 663);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(96, 41);
            this.buttonclear.TabIndex = 29;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.btn3_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(650, 663);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(107, 41);
            this.buttondelete.TabIndex = 30;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // Linkexit
            // 
            this.Linkexit.AutoSize = true;
            this.Linkexit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Linkexit.Location = new System.Drawing.Point(758, 764);
            this.Linkexit.Name = "Linkexit";
            this.Linkexit.Size = new System.Drawing.Size(30, 17);
            this.Linkexit.TabIndex = 31;
            this.Linkexit.TabStop = true;
            this.Linkexit.Text = "Exit";
            this.Linkexit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Linklogout
            // 
            this.Linklogout.AutoSize = true;
            this.Linklogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Linklogout.Location = new System.Drawing.Point(13, 9);
            this.Linklogout.Name = "Linklogout";
            this.Linklogout.Size = new System.Drawing.Size(52, 17);
            this.Linklogout.TabIndex = 32;
            this.Linklogout.TabStop = true;
            this.Linklogout.Text = "Logout";
            this.Linklogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // Groupboxregistration
            // 
            this.Groupboxregistration.Controls.Add(this.labelParentdetails);
            this.Groupboxregistration.Controls.Add(this.labelContactdetails);
            this.Groupboxregistration.Controls.Add(this.groupBox2);
            this.Groupboxregistration.Controls.Add(this.labelregistrationno);
            this.Groupboxregistration.Controls.Add(this.ComboBox);
            this.Groupboxregistration.Controls.Add(this.buttonclear);
            this.Groupboxregistration.Controls.Add(this.buttondelete);
            this.Groupboxregistration.Controls.Add(this.buttonupdate);
            this.Groupboxregistration.Controls.Add(this.buttonregister);
            this.Groupboxregistration.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupboxregistration.Location = new System.Drawing.Point(16, 49);
            this.Groupboxregistration.Name = "Groupboxregistration";
            this.Groupboxregistration.Size = new System.Drawing.Size(772, 712);
            this.Groupboxregistration.TabIndex = 33;
            this.Groupboxregistration.TabStop = false;
            this.Groupboxregistration.Text = "Student Registration";
            // 
            // labelParentdetails
            // 
            this.labelParentdetails.Controls.Add(this.labelParentname);
            this.labelParentdetails.Controls.Add(this.textboxpname);
            this.labelParentdetails.Controls.Add(this.textboxNIC);
            this.labelParentdetails.Controls.Add(this.labelNIC);
            this.labelParentdetails.Controls.Add(this.textboxCnumber);
            this.labelParentdetails.Controls.Add(this.labelContactnumber);
            this.labelParentdetails.Location = new System.Drawing.Point(41, 491);
            this.labelParentdetails.Name = "labelParentdetails";
            this.labelParentdetails.Size = new System.Drawing.Size(716, 163);
            this.labelParentdetails.TabIndex = 33;
            this.labelParentdetails.TabStop = false;
            this.labelParentdetails.Text = "Parent Details";
            // 
            // labelContactdetails
            // 
            this.labelContactdetails.Controls.Add(this.textboxaddress);
            this.labelContactdetails.Controls.Add(this.labelAddress);
            this.labelContactdetails.Controls.Add(this.textboxemail);
            this.labelContactdetails.Controls.Add(this.labelemail);
            this.labelContactdetails.Controls.Add(this.textboxmobile);
            this.labelContactdetails.Controls.Add(this.labelmobile);
            this.labelContactdetails.Controls.Add(this.textboxhome);
            this.labelContactdetails.Controls.Add(this.labelhome);
            this.labelContactdetails.Location = new System.Drawing.Point(41, 264);
            this.labelContactdetails.Name = "labelContactdetails";
            this.labelContactdetails.Size = new System.Drawing.Size(716, 209);
            this.labelContactdetails.TabIndex = 32;
            this.labelContactdetails.TabStop = false;
            this.labelContactdetails.Text = "Contact Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelfirstname);
            this.groupBox2.Controls.Add(this.TextboxFName);
            this.groupBox2.Controls.Add(this.TextboxLName);
            this.groupBox2.Controls.Add(this.labellastname);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.labeldateofbirth);
            this.groupBox2.Controls.Add(this.Gender);
            this.groupBox2.Controls.Add(this.radioBtnMale);
            this.groupBox2.Controls.Add(this.radioBtnFemale);
            this.groupBox2.Location = new System.Drawing.Point(41, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 195);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 790);
            this.Controls.Add(this.Groupboxregistration);
            this.Controls.Add(this.Linklogout);
            this.Controls.Add(this.Linkexit);
            this.Controls.Add(this.labeltitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.Groupboxregistration.ResumeLayout(false);
            this.Groupboxregistration.PerformLayout();
            this.labelParentdetails.ResumeLayout(false);
            this.labelParentdetails.PerformLayout();
            this.labelContactdetails.ResumeLayout(false);
            this.labelContactdetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labelregistrationno;
        private System.Windows.Forms.Label labelfirstname;
        private System.Windows.Forms.TextBox TextboxFName;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.TextBox TextboxLName;
        private System.Windows.Forms.Label labeldateofbirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textboxaddress;
        private System.Windows.Forms.TextBox textboxemail;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelmobile;
        private System.Windows.Forms.TextBox textboxmobile;
        private System.Windows.Forms.Label labelhome;
        private System.Windows.Forms.TextBox textboxhome;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label labelParentname;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.Label labelContactnumber;
        private System.Windows.Forms.TextBox textboxpname;
        private System.Windows.Forms.TextBox textboxNIC;
        private System.Windows.Forms.TextBox textboxCnumber;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.LinkLabel Linkexit;
        private System.Windows.Forms.LinkLabel Linklogout;
        private System.Windows.Forms.GroupBox Groupboxregistration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox labelContactdetails;
        private System.Windows.Forms.GroupBox labelParentdetails;
    }
}