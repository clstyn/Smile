
namespace Smile
{
    partial class Smile_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smile_SignUp));
            this.btnSmile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsernama = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Label();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSmile
            // 
            this.btnSmile.AutoSize = true;
            this.btnSmile.BackColor = System.Drawing.Color.Transparent;
            this.btnSmile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmile.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSmile.ForeColor = System.Drawing.Color.White;
            this.btnSmile.Location = new System.Drawing.Point(10, 8);
            this.btnSmile.Name = "btnSmile";
            this.btnSmile.Size = new System.Drawing.Size(57, 22);
            this.btnSmile.TabIndex = 16;
            this.btnSmile.Text = "Smile";
            this.btnSmile.Click += new System.EventHandler(this.btnSmile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sign Up";
            // 
            // tbUsernama
            // 
            this.tbUsernama.Location = new System.Drawing.Point(27, 70);
            this.tbUsernama.MaxLength = 25;
            this.tbUsernama.Name = "tbUsernama";
            this.tbUsernama.Size = new System.Drawing.Size(206, 20);
            this.tbUsernama.TabIndex = 18;
            this.tbUsernama.TextChanged += new System.EventHandler(this.fillUsername);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(27, 95);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(206, 20);
            this.tbName.TabIndex = 19;
            this.tbName.TextChanged += new System.EventHandler(this.fillName);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(27, 167);
            this.tbPassword.MaxLength = 12;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(206, 20);
            this.tbPassword.TabIndex = 20;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.fillPass);
            // 
            // tbConfirm
            // 
            this.tbConfirm.Location = new System.Drawing.Point(27, 192);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(206, 20);
            this.tbConfirm.TabIndex = 21;
            this.tbConfirm.UseSystemPasswordChar = true;
            this.tbConfirm.TextChanged += new System.EventHandler(this.fillConfirm);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.ForeColor = System.Drawing.Color.White;
            this.radMale.Location = new System.Drawing.Point(27, 120);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(56, 20);
            this.radMale.TabIndex = 22;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.ForeColor = System.Drawing.Color.White;
            this.radFemale.Location = new System.Drawing.Point(88, 120);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(74, 20);
            this.radFemale.TabIndex = 23;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // dtBirthday
            // 
            this.dtBirthday.CalendarFont = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthday.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtBirthday.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtBirthday.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthday.Location = new System.Drawing.Point(27, 142);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(206, 21);
            this.dtBirthday.TabIndex = 24;
            this.dtBirthday.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(27, 227);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(206, 29);
            this.btnSignup.TabIndex = 25;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.AutoSize = true;
            this.btnNewAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAccount.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnNewAccount.ForeColor = System.Drawing.Color.White;
            this.btnNewAccount.Location = new System.Drawing.Point(52, 259);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(160, 16);
            this.btnNewAccount.TabIndex = 26;
            this.btnNewAccount.Text = "Already have an account";
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbConfirmPass);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.btnNewAccount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSignup);
            this.panel1.Controls.Add(this.tbUsernama);
            this.panel1.Controls.Add(this.dtBirthday);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.radFemale);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.radMale);
            this.panel1.Controls.Add(this.tbConfirm);
            this.panel1.Location = new System.Drawing.Point(342, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 312);
            this.panel1.TabIndex = 27;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(234, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.BackColor = System.Drawing.Color.White;
            this.lbConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPass.ForeColor = System.Drawing.Color.Gray;
            this.lbConfirmPass.Location = new System.Drawing.Point(33, 195);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(100, 13);
            this.lbConfirmPass.TabIndex = 30;
            this.lbConfirmPass.Text = "Confirm Password...";
            this.lbConfirmPass.Click += new System.EventHandler(this.lbConfirmPass_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.White;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.Gray;
            this.lbPass.Location = new System.Drawing.Point(33, 170);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(62, 13);
            this.lbPass.TabIndex = 29;
            this.lbPass.Text = "Password...";
            this.lbPass.Click += new System.EventHandler(this.lbPass_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Gray;
            this.lbName.Location = new System.Drawing.Point(33, 98);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 13);
            this.lbName.TabIndex = 28;
            this.lbName.Text = "Your Name...";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.White;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Gray;
            this.lbUsername.Location = new System.Drawing.Point(31, 73);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(64, 13);
            this.lbUsername.TabIndex = 27;
            this.lbUsername.Text = "Username...";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // Smile_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Controls.Add(this.btnSmile);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Smile_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smile_SignUp";
            this.Load += new System.EventHandler(this.Smile_SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnSmile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsernama;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label btnNewAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUsername;
    }
}