
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
            this.moodStatus1 = new Smile.MoodStatus();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblEditProfile);
            this.panel1.Controls.Add(this.lblMoodStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 756);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(155, 358);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 44);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(178, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(76, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 240);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.lblEditProfile.Location = new System.Drawing.Point(111, 580);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(217, 44);
            this.lblEditProfile.TabIndex = 1;
            this.lblEditProfile.Text = "Edit Profile";
            this.lblEditProfile.Click += new System.EventHandler(this.lblEditProfile_Click);
            // 
            // lblMoodStatus
            // 
            this.lblMoodStatus.AutoSize = true;
            this.lblMoodStatus.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.lblMoodStatus.Location = new System.Drawing.Point(102, 490);
            this.lblMoodStatus.Name = "lblMoodStatus";
            this.lblMoodStatus.Size = new System.Drawing.Size(243, 44);
            this.lblMoodStatus.TabIndex = 0;
            this.lblMoodStatus.Text = "Mood Status";
            this.lblMoodStatus.Click += new System.EventHandler(this.lblMoodStatus_Click);
            // 
            // editProfile1
            // 
            this.editProfile1.BackColor = System.Drawing.Color.RosyBrown;
            this.editProfile1.Location = new System.Drawing.Point(426, -6);
            this.editProfile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editProfile1.Name = "editProfile1";
            this.editProfile1.Size = new System.Drawing.Size(937, 756);
            this.editProfile1.TabIndex = 1;
            // 
            // moodStatus1
            // 
            this.moodStatus1.BackColor = System.Drawing.Color.Transparent;
            this.moodStatus1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moodStatus1.BackgroundImage")));
            this.moodStatus1.Location = new System.Drawing.Point(427, 1);
            this.moodStatus1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moodStatus1.Name = "moodStatus1";
            this.moodStatus1.Size = new System.Drawing.Size(937, 756);
            this.moodStatus1.TabIndex = 2;
            // 
            // Smile_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 756);
            this.Controls.Add(this.moodStatus1);
            this.Controls.Add(this.editProfile1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Smile_Profile";
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
        private MoodStatus moodStatus1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
    }
}