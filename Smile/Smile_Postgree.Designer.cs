
namespace Smile
{
    partial class Smile_Postgree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smile_Postgree));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDB = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUname = new System.Windows.Forms.Label();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-8, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 493);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.lbDB);
            this.panel2.Controls.Add(this.lbPass);
            this.panel2.Controls.Add(this.lbUname);
            this.panel2.Controls.Add(this.tbDatabase);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSignIn);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.tbUsername);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(334, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 256);
            this.panel2.TabIndex = 0;
            // 
            // lbDB
            // 
            this.lbDB.AutoSize = true;
            this.lbDB.BackColor = System.Drawing.Color.White;
            this.lbDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbDB.Location = new System.Drawing.Point(93, 161);
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(60, 13);
            this.lbDB.TabIndex = 27;
            this.lbDB.Text = "DB name...";
            this.lbDB.Click += new System.EventHandler(this.lbDB_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.White;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbPass.Location = new System.Drawing.Point(92, 121);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(62, 13);
            this.lbPass.TabIndex = 26;
            this.lbPass.Text = "Password...";
            this.lbPass.Click += new System.EventHandler(this.lbPass_Click);
            // 
            // lbUname
            // 
            this.lbUname.AutoSize = true;
            this.lbUname.BackColor = System.Drawing.Color.White;
            this.lbUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbUname.Location = new System.Drawing.Point(91, 96);
            this.lbUname.Name = "lbUname";
            this.lbUname.Size = new System.Drawing.Size(64, 13);
            this.lbUname.TabIndex = 25;
            this.lbUname.Text = "Username...";
            this.lbUname.Click += new System.EventHandler(this.lbUname_Click);
            // 
            // tbDatabase
            // 
            this.tbDatabase.Location = new System.Drawing.Point(23, 158);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(206, 20);
            this.tbDatabase.TabIndex = 24;
            this.tbDatabase.TextChanged += new System.EventHandler(this.fillDB);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.btnBack.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(231, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(15, 16);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "x";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sign Postgree";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(23, 184);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(206, 25);
            this.btnSignIn.TabIndex = 20;
            this.btnSignIn.Text = "Validate";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(23, 118);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(206, 20);
            this.tbPassword.TabIndex = 19;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.fillPass);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(23, 93);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(206, 20);
            this.tbUsername.TabIndex = 18;
            this.tbUsername.TextChanged += new System.EventHandler(this.fillUname);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(-116, -76);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "X";
            // 
            // Smile_Postgree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 454);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Smile_Postgree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smile_Postgree";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.Label lbUname;
        private System.Windows.Forms.Label lbDB;
        private System.Windows.Forms.Label lbPass;
    }
}