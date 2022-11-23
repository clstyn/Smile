
namespace Smile
{
    partial class Smile_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smile_Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.lblMoodStatus = new System.Windows.Forms.Label();
            this.editProfile1 = new Smile.EditProfile();
            this.moodStatus2 = new Smile.MoodStatus();
            this.btnExit = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblEditProfile);
            this.panel1.Controls.Add(this.lblMoodStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 487);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(102, 232);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 29);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(119, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(79, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 95);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.lblEditProfile.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEditProfile.Location = new System.Drawing.Point(74, 328);
            this.lblEditProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(144, 29);
            this.lblEditProfile.TabIndex = 1;
            this.lblEditProfile.Text = "Edit Profile";
            this.lblEditProfile.Click += new System.EventHandler(this.lblEditProfile_Click);
            // 
            // lblMoodStatus
            // 
            this.lblMoodStatus.AutoSize = true;
            this.lblMoodStatus.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.lblMoodStatus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMoodStatus.Location = new System.Drawing.Point(68, 285);
            this.lblMoodStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoodStatus.Name = "lblMoodStatus";
            this.lblMoodStatus.Size = new System.Drawing.Size(162, 29);
            this.lblMoodStatus.TabIndex = 0;
            this.lblMoodStatus.Text = "Mood Status";
            this.lblMoodStatus.Click += new System.EventHandler(this.lblMoodStatus_Click);
            // 
            // editProfile1
            // 
            this.editProfile1.BackColor = System.Drawing.Color.RosyBrown;
            this.editProfile1.Location = new System.Drawing.Point(289, 0);
            this.editProfile1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.editProfile1.Name = "editProfile1";
            this.editProfile1.Size = new System.Drawing.Size(625, 491);
            this.editProfile1.TabIndex = 1;
            // 
            // moodStatus2
            // 
            this.moodStatus2.BackColor = System.Drawing.Color.Transparent;
            this.moodStatus2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moodStatus2.BackgroundImage")));
            this.moodStatus2.Location = new System.Drawing.Point(280, 0);
            this.moodStatus2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.moodStatus2.Name = "moodStatus2";
            this.moodStatus2.Size = new System.Drawing.Size(631, 491);
            this.moodStatus2.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(252, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "x";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.LightCoral;
            this.btnLogOut.Location = new System.Drawing.Point(84, 435);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(109, 29);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Smile_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 487);
            this.Controls.Add(this.moodStatus2);
            this.Controls.Add(this.editProfile1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Smile_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smile_Profile";
            this.Load += new System.EventHandler(this.Smile_Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMoodStatus;
        private System.Windows.Forms.Label lblEditProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EditProfile editProfile1;
        //private MoodStatus moodStatus1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private MoodStatus moodStatus2;
        private System.Windows.Forms.Label btnLogOut;
        private System.Windows.Forms.Label btnExit;
    }
}