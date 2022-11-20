
namespace Smile
{
    partial class EditProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemove = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbUsernama = new System.Windows.Forms.TextBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(299, 840);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(439, 33);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "Want to remove your account?";
            this.btnRemove.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(469, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 57);
            this.label1.TabIndex = 27;
            this.label1.Text = "Edit";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(341, 740);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(343, 80);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(341, 215);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.MaxLength = 25;
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "username";
            this.tbName.Size = new System.Drawing.Size(341, 45);
            this.tbName.TabIndex = 28;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtBirthday.Location = new System.Drawing.Point(341, 453);
            this.dtBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(341, 45);
            this.dtBirthday.TabIndex = 34;
            this.dtBirthday.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // tbUsernama
            // 
            this.tbUsernama.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsernama.Location = new System.Drawing.Point(341, 308);
            this.tbUsernama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsernama.Name = "tbUsernama";
            this.tbUsernama.PlaceholderText = "name";
            this.tbUsernama.Size = new System.Drawing.Size(341, 45);
            this.tbUsernama.TabIndex = 29;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.BackColor = System.Drawing.Color.Transparent;
            this.radFemale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radFemale.ForeColor = System.Drawing.Color.Cornsilk;
            this.radFemale.Location = new System.Drawing.Point(551, 377);
            this.radFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(133, 44);
            this.radFemale.TabIndex = 33;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(341, 550);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.MaxLength = 12;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderText = "password";
            this.tbPassword.Size = new System.Drawing.Size(341, 45);
            this.tbPassword.TabIndex = 30;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.BackColor = System.Drawing.Color.Transparent;
            this.radMale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radMale.ForeColor = System.Drawing.Color.Cornsilk;
            this.radMale.Location = new System.Drawing.Point(341, 377);
            this.radMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(105, 44);
            this.radMale.TabIndex = 32;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = false;
            // 
            // tbConfirm
            // 
            this.tbConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbConfirm.Location = new System.Drawing.Point(341, 640);
            this.tbConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PlaceholderText = "confirm password";
            this.tbConfirm.Size = new System.Drawing.Size(341, 45);
            this.tbConfirm.TabIndex = 31;
            this.tbConfirm.UseSystemPasswordChar = true;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.tbUsernama);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.tbConfirm);
            this.Name = "EditProfile";
            this.Size = new System.Drawing.Size(1074, 1003);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.TextBox tbUsernama;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox tbConfirm;
    }
}
