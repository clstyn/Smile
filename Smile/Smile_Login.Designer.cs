
namespace Smile
{
    partial class Smile_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smile_Login));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSmile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(373, 178);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(206, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(373, 203);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(206, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(373, 239);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(206, 25);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.AutoSize = true;
            this.btnNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.btnNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAccount.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnNewAccount.ForeColor = System.Drawing.Color.White;
            this.btnNewAccount.Location = new System.Drawing.Point(410, 267);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(137, 16);
            this.btnNewAccount.TabIndex = 3;
            this.btnNewAccount.Text = "Create New Account";
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign In";
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
            this.btnSmile.TabIndex = 15;
            this.btnSmile.Text = "Smile";
            this.btnSmile.Click += new System.EventHandler(this.btnSmile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(350, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 250);
            this.panel1.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(234, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Smile_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Controls.Add(this.btnSmile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Smile_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Smile_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label btnNewAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnSmile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnExit;
    }
}