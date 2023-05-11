
namespace Skills_International
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Labelusername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.Groupbox = new System.Windows.Forms.GroupBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.Picturebox = new System.Windows.Forms.PictureBox();
            this.Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Labelusername
            // 
            this.Labelusername.AutoSize = true;
            this.Labelusername.Location = new System.Drawing.Point(68, 85);
            this.Labelusername.Name = "Labelusername";
            this.Labelusername.Size = new System.Drawing.Size(107, 25);
            this.Labelusername.TabIndex = 0;
            this.Labelusername.Text = "Username";
            this.Labelusername.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(68, 146);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(104, 25);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(117, 212);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(103, 44);
            this.buttonclear.TabIndex = 2;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.btn1_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(305, 211);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(104, 45);
            this.buttonlogin.TabIndex = 3;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.btn2_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(24, 548);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(107, 44);
            this.buttonexit.TabIndex = 4;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.btn3_Click);
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(196, 78);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(179, 30);
            this.textboxusername.TabIndex = 5;
            this.textboxusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(196, 143);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(179, 30);
            this.textboxpassword.TabIndex = 6;
            this.textboxpassword.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // Groupbox
            // 
            this.Groupbox.Controls.Add(this.Labelusername);
            this.Groupbox.Controls.Add(this.textboxpassword);
            this.Groupbox.Controls.Add(this.buttonlogin);
            this.Groupbox.Controls.Add(this.textboxusername);
            this.Groupbox.Controls.Add(this.buttonclear);
            this.Groupbox.Controls.Add(this.labelPassword);
            this.Groupbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupbox.Location = new System.Drawing.Point(91, 225);
            this.Groupbox.Name = "Groupbox";
            this.Groupbox.Size = new System.Drawing.Size(499, 274);
            this.Groupbox.TabIndex = 7;
            this.Groupbox.TabStop = false;
            this.Groupbox.Text = "Login";
            this.Groupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(177, 163);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(338, 46);
            this.labeltitle.TabIndex = 8;
            this.labeltitle.Text = "Skills International";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labeltitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Picturebox
            // 
            this.Picturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picturebox.BackgroundImage")));
            this.Picturebox.Location = new System.Drawing.Point(288, 26);
            this.Picturebox.Name = "Picturebox";
            this.Picturebox.Size = new System.Drawing.Size(114, 87);
            this.Picturebox.TabIndex = 9;
            this.Picturebox.TabStop = false;
            this.Picturebox.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(666, 611);
            this.Controls.Add(this.Picturebox);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.Groupbox);
            this.Controls.Add(this.buttonexit);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login-Skills International";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Groupbox.ResumeLayout(false);
            this.Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Labelusername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.GroupBox Groupbox;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.PictureBox Picturebox;
    }
}

